﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Web;
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;



namespace SharpEditor
{

    public partial class Form1 : Form
    {
        DirectoryInfo tempdi;
        Point startCorner, up, down;
        Rectangle rubberBand;
        Color rubberBandColor = Color.Red;
        Boolean rubberBanding = false;
        int listNum, totalPages, finishX, finishY, startX, startY;
        // string strFilePath, filename, tempfile = "temp.tif", strPath, strFileName;
        Bitmap srcBmp;
        Image pic, resized;
        PrintDocument prntDoc = new PrintDocument();
        Graphics g;
        FileStream fs;
        List<RedactDoc> imgLst = new List<RedactDoc>();
        MemoryStream ms = new MemoryStream();

        private string[] allowedExtensions = {
    ".gif",
    ".jpg",
    ".bmp",
    ".png",
    ".tiff",
    ".tif"
};

        public Form1()
        {
            InitializeComponent();
            ImgList();
        }

        //Toolbar Import Folder Button
        private void btnImportFolder_Click(object sender, EventArgs e)
        {
            if ((ImportDirDialog.ShowDialog() == DialogResult.OK))
            {
                ImportDir(ImportDirDialog.SelectedPath);
            }
        }

        //Sets the picturebox to the selected thumbnail (Listbox Item)
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pic = Image.FromStream(imgLst[SelectedDocnum()].ImageStream);
            // pic = Image.FromFile(imgLst[listNum].FileName);
            pictureBox1.Width = pic.Width;
            pictureBox1.Height = pic.Height;
            pictureBox1.Image = pic;
        }

        //Clears Image list
        private void tlbrBtnClear_Click(object sender, EventArgs e)
        {
            clearcache();
        }

        //Toolbar Save button  --  *** NOT USED ***  This is now called after the mouse up event so that it automatically saves.  
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //savemouse();
            tiff2PDF();
        }


        //Toolbar open File (import file)
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
                addimage2(openFile.FileName);
            ImgList();
        }

        //Adds an Image to Image <rDoc>  for editing and storage (Stores in memory compared to old 'void addimage' disk method.
        void addimage2(string filename)
        {

            tempdi = Globals.tempdi;
            fs = File.Open(filename, FileMode.Open, FileAccess.ReadWrite);
            srcBmp = (Bitmap)Bitmap.FromStream(fs);
            totalPages = Convert.ToInt32(srcBmp.GetFrameCount(FrameDimension.Page) - 1);
            int i;
            for (i = 0; i <= totalPages; i++)
            {
                srcBmp.SelectActiveFrame(FrameDimension.Page, i);

                //resized = new Bitmap(srcBmp, srcBmp.Width, srcBmp.Height);
                resized = new Bitmap(srcBmp, Convert.ToInt32(srcBmp.Width / 2.8), Convert.ToInt32(srcBmp.Height / 2.8));
                // if (srcBmp.Width > 1200)
                // {
                //     resized = ResizeImage(resized, new Size(Convert.ToInt32(srcBmp.Width / 2.8), Convert.ToInt32(srcBmp.Height / 3.2)), true);
                // }
                int num = tempdi.GetFiles().Count();
                resized.Save(Application.StartupPath + "\\temp\\temp" + num + ".png", System.Drawing.Imaging.ImageFormat.Png);
                RedactDoc rDoc = new RedactDoc();
                rDoc.PageNum = string.Format("Page {0}", num +1);
                ms = new MemoryStream();
                resized.Save(ms, ImageFormat.Jpeg);
                rDoc.ImageStream = ms;
                rDoc.FileName = Application.StartupPath + "\\temp\\temp" + num + ".png";
                imgLst.Add(rDoc);
                ms = null;
                srcBmp.Dispose();
                srcBmp = null;

                resized.Dispose();
            }
            fs.Dispose();
            progressBar1.PerformStep();

            fs = null;
                 }

        
        
        //Reduces Image Size
        public static Image ResizeImage(Image image, Size size, bool preserveAspectRatio)
        {
            int newWidth = 0;
            int newHeight = 0;
            if (preserveAspectRatio == true)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = Convert.ToSingle(size.Width) / Convert.ToSingle(originalWidth);
                float percentHeight = Convert.ToSingle(size.Height) / Convert.ToSingle(originalHeight);
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = Convert.ToInt32(originalWidth * percent);
                newHeight = Convert.ToInt32(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;

            }
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        #region Draw Rectangle on PictureBox1

        private void PictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & trckbrEdit.Value == 1)
            {
                rubberBanding = true;
                startCorner = e.Location;
                rubberBand = Rectangle.Empty;
                down = new Point(startCorner.X, startCorner.Y);
                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (rubberBanding)
            {
                rubberBand.Width = Math.Abs(e.X - startCorner.X);
                rubberBand.Height = Math.Abs(e.Y - startCorner.Y);
                rubberBand.X = Math.Min(e.X, startCorner.X);
                rubberBand.Y = Math.Min(e.Y, startCorner.Y);
                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left & trckbrEdit.Value == 1)
            {
                System.Drawing.Image img = default(System.Drawing.Image);
                //sets the current page as image.
                img = new Bitmap(pictureBox1.Image);

                SolidBrush b = new SolidBrush(Color.White);
                Graphics g = default(Graphics);
                Rectangle DrawRect = default(Rectangle);

                Bitmap objBmp = new Bitmap(img, img.Width, img.Height);
                //Bitmap objNewBmp = new Bitmap(objBmp.Width, objBmp.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
                g = Graphics.FromImage(objBmp);
                //Creats a duplicate image file as bitmap format 

                //Sets the position of the mouse
                finishX = e.X;
                finishY = e.Y;

                up = new Point(finishX, finishY);
                //Sets the value of rectangle, x, y, width, height position
                DrawRect = new Rectangle(Math.Min(up.X, down.X), Math.Min(up.Y, down.Y), Math.Abs(up.X - down.X), Math.Abs(up.Y - down.Y));

                //g.DrawImage(img, DrawRect);
                //g.FillRectangle(b, DrawRect);

                //Creates an rectagnle on the picture box for visual.
                //g = pictureBox1.CreateGraphics();
                g.FillRectangle(b, DrawRect);

                //g.Dispose();
                //objNewBmp.Save("c:\temp\s" & ".tif", Imaging.ImageFormat.Tiff)
                pictureBox1.Image = objBmp;
                //cboFrameEdit.Items.Add(curF)
                g.Dispose();
                //objBmp.Dispose();
                //objNewBmp.Dispose()

                rubberBanding = false;
                //pictureBox1.Invalidate();

                //
                savemouse();
            }
            //pn.Dispose()

        }

        private void PictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (Pen pn = new Pen(rubberBandColor) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                e.Graphics.DrawRectangle(pn, rubberBand);
                SolidBrush b = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(b, rubberBand);
            }

        }

        #endregion

        //Adds each image in the temp directory to the imaage list for thumbnail viewing in List box 
        public void ImgList()
        {
            this.Cursor = Cursors.WaitCursor;
            listView1.Items.Clear();
            imageList1.Images.Clear();
            tempdi = Globals.tempdi;
            dynamic num = 0;
            int i;
            for (i = 0; i < imgLst.Count(); i++)
            {

                //imageList1.Images.Add("ico" + i, Image.FromStream(imgLst[num].ImageStream));
                imageList1.Images.Add(imgLst[i].PageNum, Image.FromStream(imgLst[num].ImageStream));
                listView1.Items.Add(Convert.ToString(num), imgLst[i].PageNum, num);
                num++;
            }
            this.Cursor = Cursors.Default;
            progressBar1.Value = 0;

        }

        //Saves picturebox(canvas) after editing  (rectangle, etc.)
        public void savemouse()
        {
            //'Saves the picturebox image in a temp folder
            Bitmap objNewBmp = new Bitmap(pictureBox1.Image);
            Graphics g = default(Graphics);

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listNum = item.Index;
            }
            g = Graphics.FromImage(objNewBmp);
            g = pictureBox1.CreateGraphics();
            ms = new MemoryStream();
            objNewBmp.Save(ms, ImageFormat.Png);
            objNewBmp.Save(Application.StartupPath + "\\temp\\temp" + listNum + ".png", System.Drawing.Imaging.ImageFormat.Png);
            imgLst[listNum].ImageStream = ms;
            imageList1.Images[listNum] = new Bitmap(objNewBmp, 128, 128);
            listView1.RedrawItems(listNum, listNum, false);
        }

        //Imports a directory of image files using the allowedExtensions arrary
        public void ImportDir(string dirPath)
        {
            DirectoryInfo di = new DirectoryInfo(dirPath);
            foreach (FileInfo fi in di.GetFiles())
            {

                foreach (string extension in allowedExtensions)
                {
                    if (extension == System.IO.Path.GetExtension(fi.FullName))
                    {
                        addimage2(fi.FullName);

                    }
                }
            }

            ImgList();
        }

        //Sets up the Print Document from the Picture Box image
        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {
            Bitmap myBitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }

        //Prints the myPrinDocument2 
        private void btnPrintPicture_Click(object sender, EventArgs e)

        {
            //System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();
            prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = prntDoc;
            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
                prntDoc.Print();

            }
        }

        //Print Preview myPrintDocument2
        void HelpToolStripButtonClick(object sender, EventArgs e)

        {
            PrintPreviewDialog myPrinDialog1 = new PrintPreviewDialog();
            prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = prntDoc;
            //myPrinDialog1.ClientSize = new System.Drawing.Size(400, 300);
            //prntDoc.OriginAtMargins = true;
            myPrinDialog1.ShowDialog();
        }

        //Converts PDF to Image files using GhostScript.exe
        private void PdfToJpg(string inputPDFFile, string outputImagesPath)
        {

            string ghostScriptPath = Application.StartupPath + "\\gswin32.exe";
            String ars = "-dNOPAUSE -sDEVICE=pnggray -r300x300  -o\"" + outputImagesPath + "%d.png\" -sPAPERSIZE=a4 \"" + inputPDFFile + "\"";
            Process proc = new Process();
            proc.StartInfo.FileName = ghostScriptPath;
            proc.StartInfo.Arguments = ars;
            proc.StartInfo.CreateNoWindow = true;
            //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
            //Debug.Print(outputImagesPath + ".tiff");
            //            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\temp\\pdf\\");
            //            foreach (FileInfo fi in di.GetFiles())
            //            {
            //                addimage2(fi.FullName);
            //                //ImageList1.Images.Add(Image.FromFile(dirFile))
            //            }
            progressBar1.Value = progressBar1.Maximum / 2;

            ImportDir(Application.StartupPath + "\\temp\\pdf\\");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearcache();
        }

        //Imports a PDF then calls the PDFtoJpg procedure to convert to image files
        void ToolStripButton1Click(object sender, EventArgs e)
        {
            DialogResult result = openPDFDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            { // Test result.
                this.Cursor = Cursors.WaitCursor;
                string outputpath = Application.StartupPath + "\\temp\\pdf\\pdf";
                PdfDocument inputDocument1 = PdfReader.Open(openPDFDialog.FileName, PdfDocumentOpenMode.Import);
                Debug.Print(string.Format("{0}", inputDocument1.PageCount));
                progressBar1.Maximum = inputDocument1.PageCount * 2;
                PdfToJpg(openPDFDialog.FileName, outputpath);
            }
        }





        #region "TIFF To PDF  **Using PDFSHARP .NET**"
        public void tiff2PDF()
        {
            PdfDocument doc = new PdfDocument();
            //int pageCount = tiff.getPageCount(fileName);
            int pageCount = listView1.Items.Count;
            for (int i = 0; i <= pageCount - 1; i++)
            {
                PdfPage page = new PdfPage();

                //Image tiffImg = tiff.getTiffImage(fileName, i);
                //Image tiffImg = Image.FromFile(Application.StartupPath + "temp" + i + ".png");
                Image tiffImg = Image.FromStream(imgLst[i].ImageStream);

                XImage img = XImage.FromGdiPlusImage(tiffImg);

                page.Width = img.PointWidth;
                page.Height = img.PointHeight;
                doc.Pages.Add(page);

                //XGraphics xgr = XGraphics.FromPdfPage(doc.Pages(i));
                XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]);

                xgr.DrawImage(img, 0, 0);
            }

            doc.Save("temp.pdf");

            doc.Close();

        }
        void PrintToolStripButtonClick(object sender, EventArgs e)
        {
            //System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();
            prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = prntDoc;
            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
                prntDoc.Print();

            }
        }
        void Button1Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listNum = item.Index;
                pic = Image.FromStream(imgLst[listNum].ImageStream);
                // pic = Image.FromFile(imgLst[listNum].FileName);
                //srcBmp.SelectActiveFrame(FrameDimension.Page, item.ImageIndex)
                //PictureBox1.Image = ResizeImage(srcBmp, New Size(PictureBox1.Width, PictureBox1.Height))
                pic.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Width = pic.Width;
                pictureBox1.Height = pic.Height;
                pictureBox1.Image = pic;
                ms = new MemoryStream();
                pic.Save(ms, ImageFormat.Png);
                imgLst[listNum].ImageStream = ms;
                imageList1.Images[listNum] = new Bitmap(pic, 128, 128);
                listView1.RedrawItems(listNum, listNum, false);

            }
        }
        #endregion

        void clearcache()
        {
            imgLst.Clear();
            imageList1.Images.Clear();
            listView1.Clear();
            pictureBox1.Image = null;

            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\temp\\pdf");
            foreach (FileInfo fi in di.GetFiles())
            {

                fi.Delete();

            }
            DirectoryInfo di2 = new DirectoryInfo(Application.StartupPath + "\\temp");
            foreach (FileInfo fi in di2.GetFiles())
            {
                fi.Delete();

            }
        }


        public int SelectedDocnum()
        {

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                Globals.DocNum = item.Index;
            }
            return Globals.DocNum;

        } 
        
        
        //**End FORM CLASS **


        internal static class Globals
        {

            public static int DocNum;
            public static DirectoryInfo tempdi = new DirectoryInfo(@Application.StartupPath + "\\temp\\");


        }

        class RedactDoc
        {
            public string PageNum { get; set; }
            public MemoryStream ImageStream { get; set; }
            public string FileName { get; set; }
        }
    }
}






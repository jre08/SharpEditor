using System;
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

namespace SharpEditor
{

    public partial class Form1 : Form
    {
        DirectoryInfo tempdi;
        Point startCorner, up, down;
        Rectangle rubberBand;
        Color rubberBandColor = Color.Red;
        Boolean rubberBanding = false, importedDir = false, importedPDF = false;
        int listNum, currentPage = 0, totalPages, finishX, finishY, startX, startY;
        string strFilePath, filename, tempfile = "temp.tif", strPath, strFileName;
        Bitmap srcBmpfrm, srcBmp, imgBmp;
        Image pic, resized;
        System.Drawing.Printing.PrintDocument prntDoc = new PrintDocument();
        Graphics g;
        Pen pn;
        FileStream fs;
        List<Image> imgLst = new List<Image>();
        
        
        private void btnImportFolder_Click(object sender, EventArgs e)
        {
            if ((ImportDirDialog.ShowDialog() == DialogResult.OK))
            {
                ImportDir();

            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (importedPDF == false)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listNum = item.Index;
                    srcBmp = null;
                    /*
                    fs.Dispose();
                    fs = File.Open(Application.StartupPath + "\\temp\\temp" + listNum + ".tif", FileMode.Open, FileAccess.ReadWrite);
                    srcBmp = (Bitmap)Bitmap.FromStream(fs);
                    */
                   //srcBmp = imgList[listNum];
                    
                    //srcBmpfrm = Bitmap.FromFile(Application.StartupPath & "\temp\temp" & item.Index & ".tif")
                    //srcBmp.SelectActiveFrame(FrameDimension.Page, item.ImageIndex)
                    //PictureBox1.Image = ResizeImage(srcBmp, New Size(PictureBox1.Width, PictureBox1.Height))
                   // pictureBox1.Width = srcBmp.Width;
                    //pictureBox1.Height = srcBmp.Height;
                    //pictureBox1.Image = srcBmp;
                    pictureBox1.Image = imgLst[listNum];


                }



            }
            else
            {
                //    'PictureBox1.Image = ResizeImage(srcBmp, New Size(PictureBox1.Width, PictureBox1.Height))
                //filename = System.IO.Path.Combine(folder, item.Text)
                /*
                if (Rbn_ck_Editmode.Checked == true)
                {
                    PictureBox1.Width = picsizew(srcBmp);
                    PictureBox1.Height = picsizeh(srcBmp);
                }
                */

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            savemouse();
        }





        public Form1()
        {
            InitializeComponent();
            ImgList();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            //openFile.ShowDialog();
            DialogResult result = openFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.

                addimage2(openFile.FileName);
                ImgList();
        }

        private void openFile_Fileok(object sender, EventArgs e)

        {
            addimage2(openFile.FileName);
            ImgList();
        }

        void addimage2(string filename)
        {
            tempdi = new DirectoryInfo(@Application.StartupPath + "\\temp\\");
            fs = File.Open(filename, FileMode.Open, FileAccess.ReadWrite);
            srcBmp =  (Bitmap)Bitmap.FromStream(fs);
            totalPages = Convert.ToInt32(srcBmp.GetFrameCount(FrameDimension.Page) - 1);
            int i;
            for (i = 0; i <= totalPages; i++)
            {
                srcBmp.SelectActiveFrame(FrameDimension.Page, i);

                resized = new Bitmap(srcBmp, srcBmp.Width, srcBmp.Height);
                if (srcBmp.Width > 1200)
                {
                    resized = ResizeImage(resized, new Size(Convert.ToInt32(srcBmp.Width / 2.8), Convert.ToInt32(srcBmp.Height / 3.2)), true);
                }
                int num = tempdi.GetFiles().Count();
                resized.Save(Application.StartupPath + "\\temp\\temp" + num + ".tif", System.Drawing.Imaging.ImageFormat.Tiff);
                imgLst.Add(resized);
                
                resized.Dispose();
            }
            fs.Dispose();
            //PictureBox1.Image = ResizeImage(srcBmp, New Size(PictureBox1.Width, PictureBox1.Height))
            //ListView1.Items.Item(0).Selected = True
        }

        public static Image ResizeImage(Image image, Size size, bool preserveAspectRatio)
        {
            int newWidth = 0;
            int newHeight = 0;
            if (preserveAspectRatio == true )
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
                
                
                //Rectangle rect = default(Rectangle);
                //var _with1 = rect;
                //_with1.Width = img.Width;
                //_with1.Height = img.Height;
                //_with1.X = 0;
                //_with1.Y = 0;

                

                
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

                //savemouse()

            }
            //pn.Dispose()
        }

        private void PictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (Pen pn = new Pen(rubberBandColor) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                e.Graphics.DrawRectangle(pn, rubberBand);
                SolidBrush b = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(b,rubberBand);
            }

        }
       
        #endregion


        public void ImgList()
        {
            this.Cursor = Cursors.WaitCursor;
            listView1.Items.Clear();

            imageList1.Images.Clear();
            imgBmp = null;
            tempdi = new DirectoryInfo(Application.StartupPath + "\\temp\\");
            dynamic num = 0;
            int i;
            for (i = 0; i <= tempdi.GetFiles().Count() - 1; i++)
            {
                num = i;
                 fs = File.Open(Application.StartupPath + "\\temp\\temp" + num + ".tif", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                imgBmp = (Bitmap)Bitmap.FromStream(fs);
                //Image imgBmp = Bitmap.FromFile(Application.StartupPath + "\\temp\\temp" + num + ".tif");
                imageList1.Images.Add("ico" + num, imgBmp);
                pic = Image.FromStream(fs);
                imgLst.Add(pic);
                //imageList1.Images.Add(num, Application.StartupPath + "\\temp\\temp" + num + ".tif");
                listView1.Items.Add(Convert.ToString(num), "Page" + Convert.ToString(num + 1), num);
                fs.Dispose();
                //num += 1;
            }
            this.Cursor = Cursors.Default;
        }

        public void savemouse()
        {
            //'Saves the picturebox image in a temp folder
            Bitmap objNewBmp = new Bitmap(pictureBox1.Image);
            Graphics g = default(Graphics);

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listNum = item.Index;
            }
            //ImageList1.Images.Clear()
            //ListView1.Items.Clear()
            srcBmp = null;
            fs.Dispose(); 
            //PictureBox1.Image.Dispose()
            //delete the current temp file to be overwritten by the new edited temp file
           File.Delete(Application.StartupPath + "\\temp\\temp" + listNum + ".tif");
            g = Graphics.FromImage(objNewBmp);
            //'Creats a duplicate image file as bitmap format
			            

            //'Creates an rectagnle on the picture box for visual.
            g = pictureBox1.CreateGraphics();
            objNewBmp.Save(Application.StartupPath + "\\temp\\temp" + listNum + ".tif", System.Drawing.Imaging.ImageFormat.Tiff);
            imgLst[listNum] = objNewBmp;
            //ListView1.Refresh()
            ImgList();
            //ListView1.Items.Item(ListNum).Selected = True
        }


        private string[] allowedExtensions = {
    ".gif",
    ".jpg",
    ".bmp",
    ".png",
    ".tiff",
    ".tif"
};

        public void ImportDir()
        {
            DirectoryInfo di = new DirectoryInfo(ImportDirDialog.SelectedPath);
            foreach (FileInfo  fi in di.GetFiles())
            {
               
                foreach (string extension in allowedExtensions)
                {
                    if (extension == System.IO.Path.GetExtension(fi.FullName))
                    {
                        Debug.Print(fi.Name);
                        addimage2(fi.FullName);
                        //ImageList1.Images.Add(Image.FromFile(dirFile))

                    }
                }
                //If fi.Extension = ".jpg" Then

                //End If
            }

           // dirPath.Text = ImportDirDialog.SelectedPath;
            importedDir = true;
            ImgList();
        }

private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {

            Bitmap myBitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            e.Graphics.DrawImage(myBitmap1, 0, 0);

            myBitmap1.Dispose();

        }
        
        

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
		void HelpToolStripButtonClick(object sender, EventArgs e)
			
		{
			//System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
			PrintPreviewDialog  myPrinDialog1 = new PrintPreviewDialog();
			prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
			myPrinDialog1.Document = prntDoc;
			//myPrinDialog1.ClientSize = new System.Drawing.Size(400, 300);
			//prntDoc.OriginAtMargins = true;
 			myPrinDialog1.ShowDialog();

		}
		void SaveToolStripButtonClick(object sender, EventArgs e)
		{
			savemouse();
		}




    }


}

namespace SharpEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImportDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenImage = new System.Windows.Forms.ToolStripButton();
            this.btnImportFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tlbrBtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.trckbrEdit = new System.Windows.Forms.TrackBar();
            this.openPDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.cntxtMenuDocList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrEdit)).BeginInit();
            this.cntxtMenuDocList.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.ContextMenuStrip = this.cntxtMenuDocList;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(218, 789);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(236, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 790);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 788);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Filter = "\"Picture Files|*.jpg;*.gif;*.bmp;*.png;*.tiff;*.tif| All Files|*.*\"";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenImage,
            this.btnImportFolder,
            this.toolStripButton2,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.tlbrBtnClear,
            this.toolStripSeparator,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(928, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenImage.Image")));
            this.btnOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnOpenImage.Size = new System.Drawing.Size(61, 22);
            this.btnOpenImage.Text = "&New";
            this.btnOpenImage.ToolTipText = "Open File";
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnImportFolder
            // 
            this.btnImportFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnImportFolder.Image")));
            this.btnImportFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFolder.Name = "btnImportFolder";
            this.btnImportFolder.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnImportFolder.Size = new System.Drawing.Size(66, 22);
            this.btnImportFolder.Text = "&Open";
            this.btnImportFolder.ToolTipText = "Import Folder";
            this.btnImportFolder.Click += new System.EventHandler(this.btnImportFolder_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::SharpEditor.Properties.Resources.Adobe_Acrobat_7;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButton2.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton2.Text = "&Import PDF";
            this.toolStripButton2.ToolTipText = "Import PDF";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton1Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.saveToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.ToolTipText = "Save File";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.printToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.ToolTipText = "Print ";
            this.printToolStripButton.Click += new System.EventHandler(this.PrintToolStripButtonClick);
            // 
            // tlbrBtnClear
            // 
            this.tlbrBtnClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlbrBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbrBtnClear.Name = "tlbrBtnClear";
            this.tlbrBtnClear.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tlbrBtnClear.Size = new System.Drawing.Size(74, 22);
            this.tlbrBtnClear.Text = "&Clear Files";
            this.tlbrBtnClear.ToolTipText = "Clear thumbnails";
            this.tlbrBtnClear.Click += new System.EventHandler(this.tlbrBtnClear_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.helpToolStripButton.Size = new System.Drawing.Size(30, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // trckbrEdit
            // 
            this.trckbrEdit.LargeChange = 1;
            this.trckbrEdit.Location = new System.Drawing.Point(315, 28);
            this.trckbrEdit.Maximum = 1;
            this.trckbrEdit.Name = "trckbrEdit";
            this.trckbrEdit.Size = new System.Drawing.Size(58, 45);
            this.trckbrEdit.TabIndex = 3;
            // 
            // openPDFDialog
            // 
            this.openPDFDialog.FileName = "openFile";
            this.openPDFDialog.Filter = "\"PDF Files|*.pdf|All Files|*.*\"";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rotate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // cntxtMenuDocList
            // 
            this.cntxtMenuDocList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cntxtMenuDocList.Name = "cntxtMenuDocList";
            this.cntxtMenuDocList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cntxtMenuDocList.Size = new System.Drawing.Size(132, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(928, 865);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.trckbrEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrEdit)).EndInit();
            this.cntxtMenuDocList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog ImportDirDialog;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TrackBar trckbrEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.ToolStripButton btnOpenImage;
        private System.Windows.Forms.ToolStripButton btnImportFolder;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton tlbrBtnClear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuDocList;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}




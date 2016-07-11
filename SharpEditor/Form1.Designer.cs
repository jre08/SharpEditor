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
        	this.cntxtMenuDocList = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.imageList1 = new System.Windows.Forms.ImageList(this.components);
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.ImportDirDialog = new System.Windows.Forms.FolderBrowserDialog();
        	this.openFile = new System.Windows.Forms.OpenFileDialog();
        	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        	this.btnOpenImage = new System.Windows.Forms.ToolStripButton();
        	this.btnImportFolder = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
        	this.saveToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
        	this.saveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.tlbrBtnClear = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.btnRotate = new System.Windows.Forms.ToolStripButton();
        	this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        	this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.openPDFDialog = new System.Windows.Forms.OpenFileDialog();
        	this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
        	this.cntxtMenuDocList.SuspendLayout();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.toolStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// listView1
        	// 
        	this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
        	this.listView1.ContextMenuStrip = this.cntxtMenuDocList;
        	this.listView1.LargeImageList = this.imageList1;
        	this.listView1.Location = new System.Drawing.Point(12, 92);
        	this.listView1.Name = "listView1";
        	this.listView1.Size = new System.Drawing.Size(218, 739);
        	this.listView1.SmallImageList = this.imageList1;
        	this.listView1.TabIndex = 0;
        	this.listView1.UseCompatibleStateImageBehavior = false;
        	this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
        	// 
        	// cntxtMenuDocList
        	// 
        	this.cntxtMenuDocList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.deleteToolStripMenuItem,
			this.saveSelectedToolStripMenuItem1,
			this.saveAllToolStripMenuItem1});
        	this.cntxtMenuDocList.Name = "cntxtMenuDocList";
        	this.cntxtMenuDocList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
        	this.cntxtMenuDocList.Size = new System.Drawing.Size(146, 70);
        	// 
        	// deleteToolStripMenuItem
        	// 
        	this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        	this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
        	this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.deleteToolStripMenuItem.Text = "Delete";
        	this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
        	// 
        	// saveSelectedToolStripMenuItem1
        	// 
        	this.saveSelectedToolStripMenuItem1.Name = "saveSelectedToolStripMenuItem1";
        	this.saveSelectedToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
        	this.saveSelectedToolStripMenuItem1.Text = "Save Selected";
        	this.saveSelectedToolStripMenuItem1.Click += new System.EventHandler(this.saveSelectedToolStripMenuItem1_Click);
        	// 
        	// saveAllToolStripMenuItem1
        	// 
        	this.saveAllToolStripMenuItem1.Name = "saveAllToolStripMenuItem1";
        	this.saveAllToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
        	this.saveAllToolStripMenuItem1.Text = "Save All";
        	this.saveAllToolStripMenuItem1.Click += new System.EventHandler(this.saveAllToolStripMenuItem1_Click);
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
        	this.panel1.Location = new System.Drawing.Point(236, 92);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(697, 739);
        	this.panel1.TabIndex = 1;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(678, 734);
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
			this.btnRotate,
			this.ProgressBar1,
			this.helpToolStripButton});
        	this.toolStrip1.Location = new System.Drawing.Point(20, 60);
        	this.toolStrip1.Name = "toolStrip1";
        	this.toolStrip1.Size = new System.Drawing.Size(888, 25);
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
        	this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
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
        	this.saveToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.saveSelectedToolStripMenuItem,
			this.saveAllToolStripMenuItem});
        	this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
        	this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripButton.Name = "saveToolStripButton";
        	this.saveToolStripButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
        	this.saveToolStripButton.Size = new System.Drawing.Size(70, 22);
        	this.saveToolStripButton.Text = "&Save";
        	this.saveToolStripButton.ToolTipText = "Save File";
        	// 
        	// saveSelectedToolStripMenuItem
        	// 
        	this.saveSelectedToolStripMenuItem.Name = "saveSelectedToolStripMenuItem";
        	this.saveSelectedToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.saveSelectedToolStripMenuItem.Text = "Save Selected";
        	this.saveSelectedToolStripMenuItem.Click += new System.EventHandler(this.saveSelectedToolStripMenuItem_Click);
        	// 
        	// saveAllToolStripMenuItem
        	// 
        	this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
        	this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.saveAllToolStripMenuItem.Text = "Save all";
        	this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
        	// 
        	// printToolStripButton
        	// 
        	this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
        	this.printToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        	this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.printToolStripButton.Name = "printToolStripButton";
        	this.printToolStripButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
        	this.printToolStripButton.Size = new System.Drawing.Size(62, 22);
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
        	// btnRotate
        	// 
        	this.btnRotate.Image = ((System.Drawing.Image)(resources.GetObject("btnRotate.Image")));
        	this.btnRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.btnRotate.Name = "btnRotate";
        	this.btnRotate.Size = new System.Drawing.Size(61, 22);
        	this.btnRotate.Text = "Rotate";
        	this.btnRotate.ToolTipText = "Rotate";
        	this.btnRotate.Click += new System.EventHandler(this.BtnRotateClick);
        	// 
        	// ProgressBar1
        	// 
        	this.ProgressBar1.Name = "ProgressBar1";
        	this.ProgressBar1.Size = new System.Drawing.Size(100, 22);
        	this.ProgressBar1.Step = 1;
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
        	// openPDFDialog
        	// 
        	this.openPDFDialog.FileName = "openFile";
        	this.openPDFDialog.Filter = "\"PDF Files|*.pdf|All Files|*.*\"";
        	// 
        	// metroToggle1
        	// 
        	this.metroToggle1.Location = new System.Drawing.Point(531, 33);
        	this.metroToggle1.Name = "metroToggle1";
        	this.metroToggle1.Size = new System.Drawing.Size(83, 24);
        	this.metroToggle1.TabIndex = 9;
        	this.metroToggle1.Text = "Off";
        	this.metroToggle1.UseSelectable = true;
        	this.metroToggle1.CheckedChanged += new System.EventHandler(this.MetroToggle1CheckedChanged);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.AutoScroll = true;
        	this.ClientSize = new System.Drawing.Size(928, 865);
        	this.Controls.Add(this.metroToggle1);
        	this.Controls.Add(this.toolStrip1);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.listView1);
        	this.Name = "Form1";
        	this.Text = "Form1";
        	this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        	this.cntxtMenuDocList.ResumeLayout(false);
        	this.panel1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.toolStrip1.ResumeLayout(false);
        	this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.OpenFileDialog openPDFDialog;
        private System.Windows.Forms.ToolStripButton btnOpenImage;
        private System.Windows.Forms.ToolStripButton btnImportFolder;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton tlbrBtnClear;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuDocList;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton saveToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.ToolStripButton btnRotate;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
    }
}





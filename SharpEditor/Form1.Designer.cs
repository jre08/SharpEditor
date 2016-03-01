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
        	this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.importDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.clearEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.btnOpenImage = new System.Windows.Forms.ToolStripButton();
        	this.btnImportFolder = new System.Windows.Forms.ToolStripButton();
        	this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.trckbrEdit = new System.Windows.Forms.TrackBar();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.toolStrip1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.trckbrEdit)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// listView1
        	// 
        	this.listView1.LargeImageList = this.imageList1;
        	this.listView1.Location = new System.Drawing.Point(12, 51);
        	this.listView1.Name = "listView1";
        	this.listView1.Size = new System.Drawing.Size(218, 757);
        	this.listView1.SmallImageList = this.imageList1;
        	this.listView1.TabIndex = 0;
        	this.listView1.UseCompatibleStateImageBehavior = false;
        	this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
        	// 
        	// imageList1
        	// 
        	this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        	this.imageList1.ImageSize = new System.Drawing.Size(128, 128);
        	this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
        	// 
        	// panel1
        	// 
        	this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel1.AutoScroll = true;
        	this.panel1.Controls.Add(this.pictureBox1);
        	this.panel1.Location = new System.Drawing.Point(236, 51);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(680, 748);
        	this.panel1.TabIndex = 1;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Location = new System.Drawing.Point(3, 3);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(674, 713);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
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
        	// 
        	// toolStrip1
        	// 
        	this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripDropDownButton1,
			this.btnOpenImage,
			this.btnImportFolder,
			this.saveToolStripButton,
			this.printToolStripButton,
			this.toolStripButton1,
			this.toolStripSeparator1,
			this.helpToolStripButton});
        	this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        	this.toolStrip1.Name = "toolStrip1";
        	this.toolStrip1.Size = new System.Drawing.Size(928, 25);
        	this.toolStrip1.TabIndex = 2;
        	this.toolStrip1.Text = "toolStrip1";
        	// 
        	// toolStripDropDownButton1
        	// 
        	this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem1,
			this.importDirectoryToolStripMenuItem,
			this.toolStripSeparator2,
			this.clearEditorToolStripMenuItem});
        	this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
        	this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
        	this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
        	this.toolStripDropDownButton1.Text = "File";
        	this.toolStripDropDownButton1.Click += new System.EventHandler(this.ToolStripDropDownButton1Click);
        	// 
        	// toolStripMenuItem1
        	// 
        	this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        	this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
        	this.toolStripMenuItem1.Text = "Import File";
        	// 
        	// importDirectoryToolStripMenuItem
        	// 
        	this.importDirectoryToolStripMenuItem.Name = "importDirectoryToolStripMenuItem";
        	this.importDirectoryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
        	this.importDirectoryToolStripMenuItem.Text = "Import Directory";
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
        	// 
        	// clearEditorToolStripMenuItem
        	// 
        	this.clearEditorToolStripMenuItem.Name = "clearEditorToolStripMenuItem";
        	this.clearEditorToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
        	this.clearEditorToolStripMenuItem.Text = "Clear Editor";
        	// 
        	// btnOpenImage
        	// 
        	this.btnOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenImage.Image")));
        	this.btnOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.btnOpenImage.Name = "btnOpenImage";
        	this.btnOpenImage.Size = new System.Drawing.Size(51, 22);
        	this.btnOpenImage.Text = "&New";
        	this.btnOpenImage.ToolTipText = "Import File";
        	this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
        	// 
        	// btnImportFolder
        	// 
        	this.btnImportFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.btnImportFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnImportFolder.Image")));
        	this.btnImportFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.btnImportFolder.Name = "btnImportFolder";
        	this.btnImportFolder.Size = new System.Drawing.Size(23, 22);
        	this.btnImportFolder.Text = "&Open";
        	this.btnImportFolder.ToolTipText = "Import Directory";
        	this.btnImportFolder.Click += new System.EventHandler(this.saveToolStripButton_Click);
        	// 
        	// saveToolStripButton
        	// 
        	this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
        	this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripButton.Name = "saveToolStripButton";
        	this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.saveToolStripButton.Text = "&Save";
        	this.saveToolStripButton.ToolTipText = "Save";
        	this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButtonClick);
        	// 
        	// printToolStripButton
        	// 
        	this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
        	this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.printToolStripButton.Name = "printToolStripButton";
        	this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.printToolStripButton.Text = "&Print";
        	this.printToolStripButton.Click += new System.EventHandler(this.btnPrintPicture_Click);
        	// 
        	// toolStripButton1
        	// 
        	this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
        	this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButton1.Name = "toolStripButton1";
        	this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButton1.Text = "toolStripButton1";
        	this.toolStripButton1.ToolTipText = "Clear Temp Folder";
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
        	// 
        	// helpToolStripButton
        	// 
        	this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
        	this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.helpToolStripButton.Name = "helpToolStripButton";
        	this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.helpToolStripButton.Text = "He&lp";
        	this.helpToolStripButton.Click += new System.EventHandler(this.HelpToolStripButtonClick);
        	// 
        	// trckbrEdit
        	// 
        	this.trckbrEdit.LargeChange = 1;
        	this.trckbrEdit.Location = new System.Drawing.Point(268, 0);
        	this.trckbrEdit.Maximum = 1;
        	this.trckbrEdit.Name = "trckbrEdit";
        	this.trckbrEdit.Size = new System.Drawing.Size(64, 45);
        	this.trckbrEdit.TabIndex = 3;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.AutoScroll = true;
        	this.ClientSize = new System.Drawing.Size(928, 865);
        	this.Controls.Add(this.trckbrEdit);
        	this.Controls.Add(this.toolStrip1);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.listView1);
        	this.Name = "Form1";
        	this.Text = "Redact Editor";
        	this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.toolStrip1.ResumeLayout(false);
        	this.toolStrip1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.trckbrEdit)).EndInit();
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
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TrackBar trckbrEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnOpenImage;
        private System.Windows.Forms.ToolStripButton btnImportFolder;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearEditorToolStripMenuItem;
    }
}


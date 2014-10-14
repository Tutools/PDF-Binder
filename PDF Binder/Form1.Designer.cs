namespace PDF_Binder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSrcFolder = new System.Windows.Forms.Label();
            this.lblTgtFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSrcFolder = new System.Windows.Forms.TextBox();
            this.txtTgtFolder = new System.Windows.Forms.TextBox();
            this.txtEndPattern = new System.Windows.Forms.TextBox();
            this.btnSrcFolderBrowse = new System.Windows.Forms.Button();
            this.btnTgtFolderBrowse = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(536, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "About PDF Binder";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblSrcFolder
            // 
            this.lblSrcFolder.AutoSize = true;
            this.lblSrcFolder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrcFolder.Location = new System.Drawing.Point(11, 44);
            this.lblSrcFolder.Name = "lblSrcFolder";
            this.lblSrcFolder.Size = new System.Drawing.Size(87, 15);
            this.lblSrcFolder.TabIndex = 1;
            this.lblSrcFolder.Text = "Source Folder:";
            // 
            // lblTgtFolder
            // 
            this.lblTgtFolder.AutoSize = true;
            this.lblTgtFolder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTgtFolder.Location = new System.Drawing.Point(11, 76);
            this.lblTgtFolder.Name = "lblTgtFolder";
            this.lblTgtFolder.Size = new System.Drawing.Size(82, 15);
            this.lblTgtFolder.TabIndex = 1;
            this.lblTgtFolder.Text = "Target Folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "End Pattern:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 147);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtSrcFolder
            // 
            this.txtSrcFolder.Location = new System.Drawing.Point(129, 40);
            this.txtSrcFolder.Name = "txtSrcFolder";
            this.txtSrcFolder.Size = new System.Drawing.Size(322, 22);
            this.txtSrcFolder.TabIndex = 3;
            // 
            // txtTgtFolder
            // 
            this.txtTgtFolder.Location = new System.Drawing.Point(129, 73);
            this.txtTgtFolder.Name = "txtTgtFolder";
            this.txtTgtFolder.Size = new System.Drawing.Size(322, 22);
            this.txtTgtFolder.TabIndex = 3;
            // 
            // txtEndPattern
            // 
            this.txtEndPattern.Location = new System.Drawing.Point(129, 103);
            this.txtEndPattern.Name = "txtEndPattern";
            this.txtEndPattern.Size = new System.Drawing.Size(68, 22);
            this.txtEndPattern.TabIndex = 3;
            // 
            // btnSrcFolderBrowse
            // 
            this.btnSrcFolderBrowse.Location = new System.Drawing.Point(456, 39);
            this.btnSrcFolderBrowse.Name = "btnSrcFolderBrowse";
            this.btnSrcFolderBrowse.Size = new System.Drawing.Size(66, 24);
            this.btnSrcFolderBrowse.TabIndex = 4;
            this.btnSrcFolderBrowse.Text = "Browse";
            this.btnSrcFolderBrowse.UseVisualStyleBackColor = true;
            this.btnSrcFolderBrowse.Click += new System.EventHandler(this.btnSrcFolderBrowse_Click);
            // 
            // btnTgtFolderBrowse
            // 
            this.btnTgtFolderBrowse.Location = new System.Drawing.Point(456, 71);
            this.btnTgtFolderBrowse.Name = "btnTgtFolderBrowse";
            this.btnTgtFolderBrowse.Size = new System.Drawing.Size(66, 24);
            this.btnTgtFolderBrowse.TabIndex = 4;
            this.btnTgtFolderBrowse.Text = "Browse";
            this.btnTgtFolderBrowse.UseVisualStyleBackColor = true;
            this.btnTgtFolderBrowse.Click += new System.EventHandler(this.btnTgtFolderBrowse_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(536, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progBar
            // 
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(500, 20);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 212);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTgtFolderBrowse);
            this.Controls.Add(this.btnSrcFolderBrowse);
            this.Controls.Add(this.txtEndPattern);
            this.Controls.Add(this.txtTgtFolder);
            this.Controls.Add(this.txtSrcFolder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTgtFolder);
            this.Controls.Add(this.lblSrcFolder);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(552, 250);
            this.MinimumSize = new System.Drawing.Size(552, 250);
            this.Name = "MainForm";
            this.Text = "PDF Binder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblSrcFolder;
        private System.Windows.Forms.Label lblTgtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSrcFolder;
        private System.Windows.Forms.TextBox txtTgtFolder;
        private System.Windows.Forms.TextBox txtEndPattern;
        private System.Windows.Forms.Button btnSrcFolderBrowse;
        private System.Windows.Forms.Button btnTgtFolderBrowse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progBar;
    }
}


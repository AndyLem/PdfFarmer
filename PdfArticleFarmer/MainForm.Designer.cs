namespace PdfArticleFarmer
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
            this.rawBox = new System.Windows.Forms.TextBox();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectDBBtn = new System.Windows.Forms.Button();
            this.scanFilesBtn = new System.Windows.Forms.Button();
            this.scanFolderBtn = new System.Windows.Forms.Button();
            this.dontRenameBtn = new System.Windows.Forms.Button();
            this.skipBtn = new System.Windows.Forms.Button();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.journalBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prevLinesBtn = new System.Windows.Forms.Button();
            this.nextLinesBtn = new System.Windows.Forms.Button();
            this.line5Box = new System.Windows.Forms.Label();
            this.line4Box = new System.Windows.Forms.Label();
            this.line3Box = new System.Windows.Forms.Label();
            this.line2Box = new System.Windows.Forms.Label();
            this.line1Box = new System.Windows.Forms.Label();
            this.fileNameBox = new System.Windows.Forms.Label();
            this.dropPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawBox
            // 
            this.rawBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawBox.Location = new System.Drawing.Point(0, 356);
            this.rawBox.Multiline = true;
            this.rawBox.Name = "rawBox";
            this.rawBox.ReadOnly = true;
            this.rawBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rawBox.Size = new System.Drawing.Size(858, 146);
            this.rawBox.TabIndex = 0;
            this.rawBox.WordWrap = false;
            this.rawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rawBox_MouseDown);
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropPanel.Controls.Add(this.label5);
            this.dropPanel.Location = new System.Drawing.Point(233, 163);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(392, 177);
            this.dropPanel.TabIndex = 8;
            this.dropPanel.Visible = false;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(105, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Drop files here";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.label5.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 356);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectDBBtn);
            this.panel2.Controls.Add(this.scanFilesBtn);
            this.panel2.Controls.Add(this.scanFolderBtn);
            this.panel2.Controls.Add(this.dontRenameBtn);
            this.panel2.Controls.Add(this.skipBtn);
            this.panel2.Controls.Add(this.proceedBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.infoBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.journalBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.authorsBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.titleBox);
            this.panel2.Location = new System.Drawing.Point(440, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 338);
            this.panel2.TabIndex = 12;
            // 
            // selectDBBtn
            // 
            this.selectDBBtn.Location = new System.Drawing.Point(288, 6);
            this.selectDBBtn.Name = "selectDBBtn";
            this.selectDBBtn.Size = new System.Drawing.Size(115, 60);
            this.selectDBBtn.TabIndex = 27;
            this.selectDBBtn.Text = "Select target DB...";
            this.selectDBBtn.UseVisualStyleBackColor = true;
            this.selectDBBtn.Click += new System.EventHandler(this.selectDBBtn_Click);
            // 
            // scanFilesBtn
            // 
            this.scanFilesBtn.Location = new System.Drawing.Point(151, 6);
            this.scanFilesBtn.Name = "scanFilesBtn";
            this.scanFilesBtn.Size = new System.Drawing.Size(115, 60);
            this.scanFilesBtn.TabIndex = 26;
            this.scanFilesBtn.Text = "Scan file(s)...";
            this.scanFilesBtn.UseVisualStyleBackColor = true;
            this.scanFilesBtn.Click += new System.EventHandler(this.scanFilesBtn_Click);
            // 
            // scanFolderBtn
            // 
            this.scanFolderBtn.Location = new System.Drawing.Point(14, 6);
            this.scanFolderBtn.Name = "scanFolderBtn";
            this.scanFolderBtn.Size = new System.Drawing.Size(115, 60);
            this.scanFolderBtn.TabIndex = 25;
            this.scanFolderBtn.Text = "Scan folder...";
            this.scanFolderBtn.UseVisualStyleBackColor = true;
            this.scanFolderBtn.Click += new System.EventHandler(this.scanFolderBtn_Click);
            // 
            // dontRenameBtn
            // 
            this.dontRenameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dontRenameBtn.Location = new System.Drawing.Point(151, 258);
            this.dontRenameBtn.Name = "dontRenameBtn";
            this.dontRenameBtn.Size = new System.Drawing.Size(115, 60);
            this.dontRenameBtn.TabIndex = 24;
            this.dontRenameBtn.Text = "Proceed, do not rename";
            this.dontRenameBtn.UseVisualStyleBackColor = false;
            this.dontRenameBtn.Click += new System.EventHandler(this.dontRenameBtn_Click);
            // 
            // skipBtn
            // 
            this.skipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skipBtn.Location = new System.Drawing.Point(288, 258);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(115, 60);
            this.skipBtn.TabIndex = 23;
            this.skipBtn.Text = "Skip";
            this.skipBtn.UseVisualStyleBackColor = false;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.Lime;
            this.proceedBtn.Location = new System.Drawing.Point(14, 258);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(115, 60);
            this.proceedBtn.TabIndex = 22;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.UseVisualStyleBackColor = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Info";
            // 
            // infoBox
            // 
            this.infoBox.AllowDrop = true;
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Location = new System.Drawing.Point(14, 217);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(389, 20);
            this.infoBox.TabIndex = 20;
            this.infoBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.titleBox_DragDrop);
            this.infoBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.titleBox_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Journal";
            // 
            // journalBox
            // 
            this.journalBox.AllowDrop = true;
            this.journalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.journalBox.Location = new System.Drawing.Point(14, 179);
            this.journalBox.Name = "journalBox";
            this.journalBox.Size = new System.Drawing.Size(389, 20);
            this.journalBox.TabIndex = 18;
            this.journalBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.titleBox_DragDrop);
            this.journalBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.titleBox_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Authors";
            // 
            // authorsBox
            // 
            this.authorsBox.AllowDrop = true;
            this.authorsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.authorsBox.Location = new System.Drawing.Point(14, 137);
            this.authorsBox.Name = "authorsBox";
            this.authorsBox.Size = new System.Drawing.Size(389, 20);
            this.authorsBox.TabIndex = 16;
            this.authorsBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.titleBox_DragDrop);
            this.authorsBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.titleBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // titleBox
            // 
            this.titleBox.AllowDrop = true;
            this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBox.Location = new System.Drawing.Point(14, 97);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(389, 20);
            this.titleBox.TabIndex = 14;
            this.titleBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.titleBox_DragDrop);
            this.titleBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.titleBox_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prevLinesBtn);
            this.panel1.Controls.Add(this.nextLinesBtn);
            this.panel1.Controls.Add(this.line5Box);
            this.panel1.Controls.Add(this.line4Box);
            this.panel1.Controls.Add(this.line3Box);
            this.panel1.Controls.Add(this.line2Box);
            this.panel1.Controls.Add(this.line1Box);
            this.panel1.Controls.Add(this.fileNameBox);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 338);
            this.panel1.TabIndex = 11;
            // 
            // prevLinesBtn
            // 
            this.prevLinesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.prevLinesBtn.Location = new System.Drawing.Point(12, 54);
            this.prevLinesBtn.Name = "prevLinesBtn";
            this.prevLinesBtn.Size = new System.Drawing.Size(389, 23);
            this.prevLinesBtn.TabIndex = 14;
            this.prevLinesBtn.Text = "Show prev lines";
            this.prevLinesBtn.UseVisualStyleBackColor = true;
            this.prevLinesBtn.Click += new System.EventHandler(this.prevLinesBtn_Click);
            // 
            // nextLinesBtn
            // 
            this.nextLinesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nextLinesBtn.Location = new System.Drawing.Point(12, 295);
            this.nextLinesBtn.Name = "nextLinesBtn";
            this.nextLinesBtn.Size = new System.Drawing.Size(389, 23);
            this.nextLinesBtn.TabIndex = 15;
            this.nextLinesBtn.Text = "Show next lines";
            this.nextLinesBtn.UseVisualStyleBackColor = true;
            this.nextLinesBtn.Click += new System.EventHandler(this.nextLinesBtn_Click);
            // 
            // line5Box
            // 
            this.line5Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.line5Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line5Box.Location = new System.Drawing.Point(12, 256);
            this.line5Box.Name = "line5Box";
            this.line5Box.Size = new System.Drawing.Size(389, 23);
            this.line5Box.TabIndex = 13;
            this.line5Box.Text = "label1";
            this.line5Box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.line5Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.line1Box_MouseDown);
            // 
            // line4Box
            // 
            this.line4Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.line4Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line4Box.Location = new System.Drawing.Point(12, 216);
            this.line4Box.Name = "line4Box";
            this.line4Box.Size = new System.Drawing.Size(389, 23);
            this.line4Box.TabIndex = 12;
            this.line4Box.Text = "label1";
            this.line4Box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.line4Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.line1Box_MouseDown);
            // 
            // line3Box
            // 
            this.line3Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.line3Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3Box.Location = new System.Drawing.Point(12, 176);
            this.line3Box.Name = "line3Box";
            this.line3Box.Size = new System.Drawing.Size(389, 23);
            this.line3Box.TabIndex = 11;
            this.line3Box.Text = "label1";
            this.line3Box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.line3Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.line1Box_MouseDown);
            // 
            // line2Box
            // 
            this.line2Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.line2Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line2Box.Location = new System.Drawing.Point(12, 136);
            this.line2Box.Name = "line2Box";
            this.line2Box.Size = new System.Drawing.Size(389, 23);
            this.line2Box.TabIndex = 10;
            this.line2Box.Text = "label1";
            this.line2Box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.line2Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.line1Box_MouseDown);
            // 
            // line1Box
            // 
            this.line1Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.line1Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1Box.Location = new System.Drawing.Point(12, 96);
            this.line1Box.Name = "line1Box";
            this.line1Box.Size = new System.Drawing.Size(389, 23);
            this.line1Box.TabIndex = 9;
            this.line1Box.Text = "label1";
            this.line1Box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.line1Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.line1Box_MouseDown);
            // 
            // fileNameBox
            // 
            this.fileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameBox.Location = new System.Drawing.Point(12, 6);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(389, 45);
            this.fileNameBox.TabIndex = 8;
            this.fileNameBox.Text = "label1";
            this.fileNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileNameBox.MouseLeave += new System.EventHandler(this.fileNameBox_MouseLeave);
            this.fileNameBox.Click += new System.EventHandler(this.fileNameBox_Click);
            this.fileNameBox.MouseEnter += new System.EventHandler(this.fileNameBox_MouseEnter);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 502);
            this.Controls.Add(this.rawBox);
            this.Controls.Add(this.dropPanel);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(874, 1000);
            this.MinimumSize = new System.Drawing.Size(874, 500);
            this.Name = "MainForm";
            this.Text = "Pdf article farmer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.dropPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rawBox;
        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectDBBtn;
        private System.Windows.Forms.Button scanFilesBtn;
        private System.Windows.Forms.Button scanFolderBtn;
        private System.Windows.Forms.Button dontRenameBtn;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox journalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button prevLinesBtn;
        private System.Windows.Forms.Button nextLinesBtn;
        private System.Windows.Forms.Label line5Box;
        private System.Windows.Forms.Label line4Box;
        private System.Windows.Forms.Label line3Box;
        private System.Windows.Forms.Label line2Box;
        private System.Windows.Forms.Label line1Box;
        private System.Windows.Forms.Label fileNameBox;
    }
}


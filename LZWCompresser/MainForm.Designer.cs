namespace LZWCompresser
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
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.lblCompressed = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.bgNormal = new System.ComponentModel.BackgroundWorker();
            this.txtCompressed = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Title = "Open";
            // 
            // btnCompress
            // 
            this.btnCompress.Enabled = false;
            this.btnCompress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCompress.Location = new System.Drawing.Point(281, 205);
            this.btnCompress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(131, 33);
            this.btnCompress.TabIndex = 0;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOpen.Location = new System.Drawing.Point(145, 205);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(131, 33);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.Cyan;
            this.Progress.Location = new System.Drawing.Point(131, 179);
            this.Progress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Progress.MarqueeAnimationSpeed = 10;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(295, 20);
            this.Progress.TabIndex = 3;
            this.Progress.Visible = false;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(13, 59);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(260, 110);
            this.txtOriginal.TabIndex = 4;
            this.txtOriginal.TabStop = false;
            // 
            // lblCompressed
            // 
            this.lblCompressed.AutoSize = true;
            this.lblCompressed.BackColor = System.Drawing.Color.Transparent;
            this.lblCompressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompressed.ForeColor = System.Drawing.Color.Black;
            this.lblCompressed.Location = new System.Drawing.Point(281, 37);
            this.lblCompressed.Name = "lblCompressed";
            this.lblCompressed.Size = new System.Drawing.Size(0, 16);
            this.lblCompressed.TabIndex = 6;
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblOriginal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.ForeColor = System.Drawing.Color.Black;
            this.lblOriginal.Location = new System.Drawing.Point(12, 37);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(0, 16);
            this.lblOriginal.TabIndex = 7;
            // 
            // SaveFile
            // 
            this.SaveFile.Title = "Save";
            // 
            // txtPath
            // 
            this.txtPath.ForeColor = System.Drawing.Color.Blue;
            this.txtPath.Location = new System.Drawing.Point(13, 10);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(531, 23);
            this.txtPath.TabIndex = 2;
            this.txtPath.TabStop = false;
            this.txtPath.DoubleClick += new System.EventHandler(this.txtPath_DoubleClick);
            // 
            // bgNormal
            // 
            this.bgNormal.WorkerReportsProgress = true;
            this.bgNormal.WorkerSupportsCancellation = true;
            this.bgNormal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgNormal_DoWork);
            this.bgNormal.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgNormal_ProgressChanged);
            this.bgNormal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgNormal_RunWorkerCompleted);
            // 
            // txtCompressed
            // 
            this.txtCompressed.Location = new System.Drawing.Point(284, 59);
            this.txtCompressed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompressed.Multiline = true;
            this.txtCompressed.Name = "txtCompressed";
            this.txtCompressed.ReadOnly = true;
            this.txtCompressed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCompressed.Size = new System.Drawing.Size(260, 110);
            this.txtCompressed.TabIndex = 5;
            this.txtCompressed.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.Cyan;
            this.lblAbout.Location = new System.Drawing.Point(510, 228);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(47, 19);
            this.lblAbout.TabIndex = 9;
            this.lblAbout.Text = "About";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LZWCompresser.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(557, 247);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblCompressed);
            this.Controls.Add(this.txtCompressed);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnCompress);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LZWCompresser";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label lblCompressed;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.ComponentModel.BackgroundWorker bgNormal;
        private System.Windows.Forms.TextBox txtCompressed;
        private System.Windows.Forms.Label lblAbout;
    }
}


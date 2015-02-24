namespace LZWCompresser
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.producttxt = new System.Windows.Forms.Label();
            this.developrtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // producttxt
            // 
            this.producttxt.BackColor = System.Drawing.Color.Transparent;
            this.producttxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producttxt.ForeColor = System.Drawing.Color.Blue;
            this.producttxt.Location = new System.Drawing.Point(65, 7);
            this.producttxt.Name = "producttxt";
            this.producttxt.Size = new System.Drawing.Size(170, 26);
            this.producttxt.TabIndex = 2;
            this.producttxt.Text = "LZW Compresser";
            this.producttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.producttxt.Click += new System.EventHandler(this.abouttxt_Click);
            // 
            // developrtxt
            // 
            this.developrtxt.BackColor = System.Drawing.Color.Transparent;
            this.developrtxt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developrtxt.ForeColor = System.Drawing.Color.Navy;
            this.developrtxt.Location = new System.Drawing.Point(4, 33);
            this.developrtxt.Name = "developrtxt";
            this.developrtxt.Size = new System.Drawing.Size(293, 40);
            this.developrtxt.TabIndex = 3;
            this.developrtxt.Text = "Created by Mohamed Ahmed Abdel Fattah\r\nE-Mail:eng.mafattah@hotmail.com";
            this.developrtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.developrtxt.Click += new System.EventHandler(this.abouttxt_Click);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 80);
            this.Controls.Add(this.developrtxt);
            this.Controls.Add(this.producttxt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.abouttxt_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label producttxt;
        private System.Windows.Forms.Label developrtxt;

    }
}
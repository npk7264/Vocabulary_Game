namespace project1
{
    partial class Complete
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
            this.lbYourScore = new System.Windows.Forms.Label();
            this.picWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbYourScore
            // 
            this.lbYourScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYourScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbYourScore.Location = new System.Drawing.Point(521, 64);
            this.lbYourScore.Name = "lbYourScore";
            this.lbYourScore.Size = new System.Drawing.Size(240, 83);
            this.lbYourScore.TabIndex = 0;
            this.lbYourScore.Text = "label1";
            this.lbYourScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picWin
            // 
            this.picWin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picWin.BackgroundImage = global::project1.Properties.Resources.win;
            this.picWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWin.Location = new System.Drawing.Point(218, 166);
            this.picWin.Name = "picWin";
            this.picWin.Size = new System.Drawing.Size(846, 474);
            this.picWin.TabIndex = 1;
            this.picWin.TabStop = false;
            // 
            // Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 662);
            this.Controls.Add(this.picWin);
            this.Controls.Add(this.lbYourScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Complete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Complete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbYourScore;
        private System.Windows.Forms.PictureBox picWin;
    }
}
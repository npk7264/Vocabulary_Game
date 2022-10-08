namespace project1
{
    partial class HighScore
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
            this.dgvHighScore = new System.Windows.Forms.DataGridView();
            this.cboTopic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighScore
            // 
            this.dgvHighScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighScore.Location = new System.Drawing.Point(12, 117);
            this.dgvHighScore.Name = "dgvHighScore";
            this.dgvHighScore.RowHeadersWidth = 51;
            this.dgvHighScore.RowTemplate.Height = 24;
            this.dgvHighScore.Size = new System.Drawing.Size(1137, 468);
            this.dgvHighScore.TabIndex = 0;
            // 
            // cboTopic
            // 
            this.cboTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTopic.FormattingEnabled = true;
            this.cboTopic.Items.AddRange(new object[] {
            "Animal",
            "Food",
            "Fruit",
            "Sport"});
            this.cboTopic.Location = new System.Drawing.Point(429, 32);
            this.cboTopic.Name = "cboTopic";
            this.cboTopic.Size = new System.Drawing.Size(303, 44);
            this.cboTopic.TabIndex = 1;
            this.cboTopic.SelectedIndexChanged += new System.EventHandler(this.cboTopic_SelectedIndexChanged_1);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 597);
            this.Controls.Add(this.cboTopic);
            this.Controls.Add(this.dgvHighScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighScore;
        private System.Windows.Forms.ComboBox cboTopic;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHighScore = new System.Windows.Forms.DataGridView();
            this.cboTopic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighScore
            // 
            this.dgvHighScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHighScore.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHighScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHighScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHighScore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHighScore.Location = new System.Drawing.Point(40, 162);
            this.dgvHighScore.Name = "dgvHighScore";
            this.dgvHighScore.RowHeadersWidth = 51;
            this.dgvHighScore.RowTemplate.Height = 24;
            this.dgvHighScore.Size = new System.Drawing.Size(704, 431);
            this.dgvHighScore.TabIndex = 0;
            // 
            // cboTopic
            // 
            this.cboTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTopic.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTopic.FormattingEnabled = true;
            this.cboTopic.Items.AddRange(new object[] {
            "Animal",
            "Food",
            "Fruit",
            "Sport"});
            this.cboTopic.Location = new System.Drawing.Point(240, 89);
            this.cboTopic.Name = "cboTopic";
            this.cboTopic.Size = new System.Drawing.Size(303, 36);
            this.cboTopic.TabIndex = 1;
            this.cboTopic.SelectedIndexChanged += new System.EventHandler(this.cboTopic_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(284, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "High Score";
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTopic);
            this.Controls.Add(this.dgvHighScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighScore;
        private System.Windows.Forms.ComboBox cboTopic;
        private System.Windows.Forms.Label label1;
    }
}
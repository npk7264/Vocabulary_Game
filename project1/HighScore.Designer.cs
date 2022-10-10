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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHighScore = new System.Windows.Forms.DataGridView();
            this.cboTopic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighScore
            // 
            this.dgvHighScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHighScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHighScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHighScore.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHighScore.Location = new System.Drawing.Point(12, 117);
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
            this.cboTopic.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTopic.FormattingEnabled = true;
            this.cboTopic.Items.AddRange(new object[] {
            "Animal",
            "Food",
            "Fruit",
            "Sport"});
            this.cboTopic.Location = new System.Drawing.Point(213, 32);
            this.cboTopic.Name = "cboTopic";
            this.cboTopic.Size = new System.Drawing.Size(303, 43);
            this.cboTopic.TabIndex = 1;
            this.cboTopic.SelectedIndexChanged += new System.EventHandler(this.cboTopic_SelectedIndexChanged_1);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 560);
            this.Controls.Add(this.cboTopic);
            this.Controls.Add(this.dgvHighScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighScore;
        private System.Windows.Forms.ComboBox cboTopic;
    }
}
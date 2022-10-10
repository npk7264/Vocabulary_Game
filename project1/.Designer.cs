namespace project1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.WMP_music = new AxWMPLib.AxWindowsMediaPlayer();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.picHighScore = new System.Windows.Forms.PictureBox();
            this.picVocabularyList = new System.Windows.Forms.PictureBox();
            this.pnOption = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_music)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVocabularyList)).BeginInit();
            this.pnOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP_music
            // 
            this.WMP_music.Enabled = true;
            this.WMP_music.Location = new System.Drawing.Point(12, 506);
            this.WMP_music.Name = "WMP_music";
            this.WMP_music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP_music.OcxState")));
            this.WMP_music.Size = new System.Drawing.Size(75, 42);
            this.WMP_music.TabIndex = 3;
            this.WMP_music.Visible = false;
            // 
            // picStart
            // 
            this.picStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStart.BackColor = System.Drawing.Color.Transparent;
            this.picStart.BackgroundImage = global::project1.Properties.Resources._6646646_controller_games_joystick_play_videogames_icon;
            this.picStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStart.Location = new System.Drawing.Point(40, 0);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(178, 170);
            this.picStart.TabIndex = 4;
            this.picStart.TabStop = false;
            this.picStart.Click += new System.EventHandler(this.picStart_Click);
            // 
            // picHighScore
            // 
            this.picHighScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picHighScore.BackColor = System.Drawing.Color.Transparent;
            this.picHighScore.BackgroundImage = global::project1.Properties.Resources._8962563_trophy_award_winner_prize_achievement_icon;
            this.picHighScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHighScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHighScore.Location = new System.Drawing.Point(338, 3);
            this.picHighScore.Name = "picHighScore";
            this.picHighScore.Size = new System.Drawing.Size(202, 170);
            this.picHighScore.TabIndex = 5;
            this.picHighScore.TabStop = false;
            this.picHighScore.Click += new System.EventHandler(this.picHighScore_Click);
            // 
            // picVocabularyList
            // 
            this.picVocabularyList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picVocabularyList.BackColor = System.Drawing.Color.Transparent;
            this.picVocabularyList.BackgroundImage = global::project1.Properties.Resources._5740114_check_checklist_clipboard_list_mark_icon;
            this.picVocabularyList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picVocabularyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVocabularyList.Location = new System.Drawing.Point(660, 15);
            this.picVocabularyList.Name = "picVocabularyList";
            this.picVocabularyList.Size = new System.Drawing.Size(181, 155);
            this.picVocabularyList.TabIndex = 6;
            this.picVocabularyList.TabStop = false;
            this.picVocabularyList.Click += new System.EventHandler(this.picVocabularyList_Click);
            // 
            // pnOption
            // 
            this.pnOption.BackColor = System.Drawing.Color.Transparent;
            this.pnOption.Controls.Add(this.picClose);
            this.pnOption.Controls.Add(this.picHighScore);
            this.pnOption.Controls.Add(this.picVocabularyList);
            this.pnOption.Controls.Add(this.picStart);
            this.pnOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOption.Location = new System.Drawing.Point(0, 444);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(1172, 185);
            this.pnOption.TabIndex = 7;
            // 
            // picClose
            // 
            this.picClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::project1.Properties.Resources._211650_close_circled_icon;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(961, 8);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(171, 167);
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project1.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 629);
            this.Controls.Add(this.WMP_music);
            this.Controls.Add(this.pnOption);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP_music)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHighScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVocabularyList)).EndInit();
            this.pnOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer WMP_music;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.PictureBox picHighScore;
        private System.Windows.Forms.PictureBox picVocabularyList;
        private System.Windows.Forms.Panel pnOption;
        private System.Windows.Forms.PictureBox picClose;
    }
}


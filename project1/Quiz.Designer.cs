namespace project1
{
    partial class Quiz
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.pnQuestion = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnResult = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCorrectAnswer = new System.Windows.Forms.Label();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picUnmute = new System.Windows.Forms.PictureBox();
            this.picMute = new System.Windows.Forms.PictureBox();
            this.picQuiz = new System.Windows.Forms.PictureBox();
            this.pnImage = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picMic = new System.Windows.Forms.PictureBox();
            this.pnMic = new System.Windows.Forms.Panel();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.pnQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnResult.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiz)).BeginInit();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMic)).BeginInit();
            this.pnMic.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtInput.Location = new System.Drawing.Point(511, 685);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(695, 77);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // lbScore
            // 
            this.lbScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Hobo Std", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbScore.Location = new System.Drawing.Point(903, 81);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(238, 63);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "SCORE: 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnQuestion
            // 
            this.pnQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pnQuestion.Controls.Add(this.pictureBox1);
            this.pnQuestion.Location = new System.Drawing.Point(38, 288);
            this.pnQuestion.Name = "pnQuestion";
            this.pnQuestion.Size = new System.Drawing.Size(352, 366);
            this.pnQuestion.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::project1.Properties.Resources.panda_question;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 346);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pnResult
            // 
            this.pnResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnResult.BackColor = System.Drawing.Color.Transparent;
            this.pnResult.Controls.Add(this.panel1);
            this.pnResult.Controls.Add(this.picResult);
            this.pnResult.Location = new System.Drawing.Point(500, 188);
            this.pnResult.Name = "pnResult";
            this.pnResult.Size = new System.Drawing.Size(720, 466);
            this.pnResult.TabIndex = 15;
            this.pnResult.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbCorrectAnswer);
            this.panel1.Location = new System.Drawing.Point(141, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 142);
            this.panel1.TabIndex = 15;
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectAnswer.ForeColor = System.Drawing.Color.Orange;
            this.lbCorrectAnswer.Location = new System.Drawing.Point(3, 41);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(430, 64);
            this.lbCorrectAnswer.TabIndex = 15;
            this.lbCorrectAnswer.Text = "CORRECT";
            this.lbCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picResult
            // 
            this.picResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picResult.BackColor = System.Drawing.Color.Transparent;
            this.picResult.BackgroundImage = global::project1.Properties.Resources.wrong_answer;
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picResult.Location = new System.Drawing.Point(229, 186);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(276, 271);
            this.picResult.TabIndex = 12;
            this.picResult.TabStop = false;
            // 
            // picUnmute
            // 
            this.picUnmute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUnmute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.picUnmute.BackgroundImage = global::project1.Properties.Resources.volume_mute;
            this.picUnmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUnmute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUnmute.Location = new System.Drawing.Point(1196, 71);
            this.picUnmute.Name = "picUnmute";
            this.picUnmute.Size = new System.Drawing.Size(105, 82);
            this.picUnmute.TabIndex = 8;
            this.picUnmute.TabStop = false;
            this.picUnmute.Click += new System.EventHandler(this.picUnmute_Click);
            // 
            // picMute
            // 
            this.picMute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.picMute.BackgroundImage = global::project1.Properties.Resources.volume_up;
            this.picMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMute.Location = new System.Drawing.Point(1196, 71);
            this.picMute.Name = "picMute";
            this.picMute.Size = new System.Drawing.Size(105, 82);
            this.picMute.TabIndex = 7;
            this.picMute.TabStop = false;
            this.picMute.Click += new System.EventHandler(this.picMute_Click);
            // 
            // picQuiz
            // 
            this.picQuiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picQuiz.BackColor = System.Drawing.Color.White;
            this.picQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picQuiz.Location = new System.Drawing.Point(81, 47);
            this.picQuiz.Name = "picQuiz";
            this.picQuiz.Size = new System.Drawing.Size(531, 318);
            this.picQuiz.TabIndex = 0;
            this.picQuiz.TabStop = false;
            // 
            // pnImage
            // 
            this.pnImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnImage.BackColor = System.Drawing.Color.White;
            this.pnImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnImage.Controls.Add(this.picQuiz);
            this.pnImage.Location = new System.Drawing.Point(511, 201);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(695, 409);
            this.pnImage.TabIndex = 18;
            // 
            // picBack
            // 
            this.picBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBack.BackColor = System.Drawing.Color.LightSalmon;
            this.picBack.BackgroundImage = global::project1.Properties.Resources.back_arrow;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Location = new System.Drawing.Point(406, 71);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(107, 84);
            this.picBack.TabIndex = 19;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // picNext
            // 
            this.picNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(164)))), ((int)(((byte)(212)))));
            this.picNext.BackgroundImage = global::project1.Properties.Resources.next;
            this.picNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Location = new System.Drawing.Point(898, 680);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(107, 84);
            this.picNext.TabIndex = 20;
            this.picNext.TabStop = false;
            this.picNext.Visible = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picMic
            // 
            this.picMic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMic.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.picMic.BackgroundImage = global::project1.Properties.Resources.micro;
            this.picMic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMic.Location = new System.Drawing.Point(3, 11);
            this.picMic.Name = "picMic";
            this.picMic.Size = new System.Drawing.Size(101, 63);
            this.picMic.TabIndex = 21;
            this.picMic.TabStop = false;
            this.picMic.Click += new System.EventHandler(this.picMic_Click);
            // 
            // pnMic
            // 
            this.pnMic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMic.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnMic.Controls.Add(this.picMic);
            this.pnMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMic.Location = new System.Drawing.Point(729, 680);
            this.pnMic.Name = "pnMic";
            this.pnMic.Size = new System.Drawing.Size(107, 84);
            this.pnMic.TabIndex = 22;
            this.pnMic.Visible = false;
            this.pnMic.Click += new System.EventHandler(this.pnMic_Click_1);
            // 
            // lbQuestion
            // 
            this.lbQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbQuestion.Font = new System.Drawing.Font("Hobo Std", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbQuestion.Location = new System.Drawing.Point(576, 71);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(302, 82);
            this.lbQuestion.TabIndex = 25;
            this.lbQuestion.Text = "QUESTION: 1";
            this.lbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImage = global::project1.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1716, 778);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.pnMic);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.pnResult);
            this.Controls.Add(this.picUnmute);
            this.Controls.Add(this.pnQuestion);
            this.Controls.Add(this.pnImage);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.picBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.pnQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnResult.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiz)).EndInit();
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMic)).EndInit();
            this.pnMic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQuiz;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox picMute;
        private System.Windows.Forms.PictureBox picUnmute;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Panel pnResult;
        private System.Windows.Forms.Panel pnQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCorrectAnswer;
        private System.Windows.Forms.PictureBox picMic;
        private System.Windows.Forms.Panel pnMic;
        private System.Windows.Forms.Label lbQuestion;
    }
}
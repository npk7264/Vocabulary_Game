namespace project1
{
    partial class Topic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFoodTopic = new System.Windows.Forms.Button();
            this.btnAnimalTopic = new System.Windows.Forms.Button();
            this.btnFruitTopic = new System.Windows.Forms.Button();
            this.btnSportTopic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnFoodTopic);
            this.panel1.Controls.Add(this.btnAnimalTopic);
            this.panel1.Controls.Add(this.btnFruitTopic);
            this.panel1.Controls.Add(this.btnSportTopic);
            this.panel1.Location = new System.Drawing.Point(12, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 394);
            this.panel1.TabIndex = 5;
            // 
            // btnFoodTopic
            // 
            this.btnFoodTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFoodTopic.BackColor = System.Drawing.Color.Beige;
            this.btnFoodTopic.BackgroundImage = global::project1.Properties.Resources.food_topic;
            this.btnFoodTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFoodTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodTopic.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodTopic.Location = new System.Drawing.Point(889, 18);
            this.btnFoodTopic.Name = "btnFoodTopic";
            this.btnFoodTopic.Size = new System.Drawing.Size(236, 357);
            this.btnFoodTopic.TabIndex = 1;
            this.btnFoodTopic.Text = "Food";
            this.btnFoodTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoodTopic.UseVisualStyleBackColor = false;
            this.btnFoodTopic.Click += new System.EventHandler(this.btnFoodTopic_Click);
            // 
            // btnAnimalTopic
            // 
            this.btnAnimalTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnimalTopic.BackColor = System.Drawing.Color.Beige;
            this.btnAnimalTopic.BackgroundImage = global::project1.Properties.Resources.animal_topic;
            this.btnAnimalTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnimalTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimalTopic.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimalTopic.Location = new System.Drawing.Point(615, 18);
            this.btnAnimalTopic.Name = "btnAnimalTopic";
            this.btnAnimalTopic.Size = new System.Drawing.Size(237, 357);
            this.btnAnimalTopic.TabIndex = 3;
            this.btnAnimalTopic.Text = "Animal";
            this.btnAnimalTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnimalTopic.UseVisualStyleBackColor = false;
            this.btnAnimalTopic.Click += new System.EventHandler(this.btnAnimalTopic_Click);
            // 
            // btnFruitTopic
            // 
            this.btnFruitTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFruitTopic.BackColor = System.Drawing.Color.Beige;
            this.btnFruitTopic.BackgroundImage = global::project1.Properties.Resources.fruit_topic;
            this.btnFruitTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFruitTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFruitTopic.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFruitTopic.Location = new System.Drawing.Point(28, 18);
            this.btnFruitTopic.Name = "btnFruitTopic";
            this.btnFruitTopic.Size = new System.Drawing.Size(266, 357);
            this.btnFruitTopic.TabIndex = 0;
            this.btnFruitTopic.Text = "Fruit";
            this.btnFruitTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFruitTopic.UseVisualStyleBackColor = false;
            this.btnFruitTopic.Click += new System.EventHandler(this.btnFruitTopic_Click);
            // 
            // btnSportTopic
            // 
            this.btnSportTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSportTopic.BackColor = System.Drawing.Color.Beige;
            this.btnSportTopic.BackgroundImage = global::project1.Properties.Resources.sport_topic;
            this.btnSportTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSportTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSportTopic.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSportTopic.Location = new System.Drawing.Point(331, 18);
            this.btnSportTopic.Name = "btnSportTopic";
            this.btnSportTopic.Size = new System.Drawing.Size(247, 357);
            this.btnSportTopic.TabIndex = 2;
            this.btnSportTopic.Text = "Sport";
            this.btnSportTopic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSportTopic.UseVisualStyleBackColor = false;
            this.btnSportTopic.Click += new System.EventHandler(this.btnSportTopic_Click);
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::project1.Properties.Resources.content_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1176, 620);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Topic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Topic_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFruitTopic;
        private System.Windows.Forms.Button btnFoodTopic;
        private System.Windows.Forms.Button btnSportTopic;
        private System.Windows.Forms.Button btnAnimalTopic;
        private System.Windows.Forms.Panel panel1;
    }
}
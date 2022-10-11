using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Topic : Form
    {
        public Topic()
        {
            InitializeComponent();
        }

        private void btnFruitTopic_Click(object sender, EventArgs e)
        {
            Program.topic_string = "fruit";
            Quiz frm = new Quiz();
            frm.ShowDialog();
        }

        private void btnSportTopic_Click(object sender, EventArgs e)
        {
            Program.topic_string = "sport";
            Quiz frm = new Quiz();
            frm.ShowDialog();
        }

        private void btnAnimalTopic_Click(object sender, EventArgs e)
        {
            Program.topic_string = "animal";
            Quiz frm = new Quiz();
            frm.ShowDialog();
        }

        private void btnFoodTopic_Click(object sender, EventArgs e)
        {
            Program.topic_string = "food";
            Quiz frm = new Quiz();
            frm.ShowDialog();
        }

        private void Topic_Load(object sender, EventArgs e) {
        }

        private void btnFruitTopic_MouseHover(object sender, EventArgs e)
        {
            btnFruitTopic.BackColor = Color.LightSteelBlue;
        }

        private void btnFruitTopic_MouseLeave(object sender, EventArgs e)
        {
            btnFruitTopic.BackColor = Color.Beige;
        }

        private void btnSportTopic_MouseHover(object sender, EventArgs e)
        {
            btnSportTopic.BackColor = Color.LightSteelBlue;
        }

        private void btnSportTopic_MouseLeave(object sender, EventArgs e)
        {
            btnSportTopic.BackColor = Color.Beige;
        }

        private void btnAnimalTopic_MouseHover(object sender, EventArgs e)
        {
            btnAnimalTopic.BackColor = Color.LightSteelBlue;
        }

        private void btnAnimalTopic_MouseLeave(object sender, EventArgs e)
        {
            btnAnimalTopic.BackColor = Color.Beige;
        }

        private void btnFoodTopic_MouseHover(object sender, EventArgs e)
        {
            btnFoodTopic.BackColor = Color.LightSteelBlue;
        }

        private void btnFoodTopic_MouseLeave(object sender, EventArgs e)
        {
            btnFoodTopic.BackColor = Color.Beige; ;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picUnmute_Click(object sender, EventArgs e)
        {
            picMute.Visible = true;
            picUnmute.Visible = false;
            Program.music.settings.volume = 50;
        }

        private void picMute_Click(object sender, EventArgs e)
        {
            picMute.Visible = false;
            picUnmute.Visible = true;
            Program.music.settings.volume = 0;
        }
    }
}

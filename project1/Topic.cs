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
    }
}

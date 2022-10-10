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
    public partial class Complete : Form
    {
        public Complete()
        {
            InitializeComponent();
        }

        private void Complete_Load(object sender, EventArgs e)
        {
            lbYourScore.Text = Program.nick_score.ToString();
            lbHighScore.Text = Convert.ToString(Functions.GetFieldValues("SELECT Score FROM " + Program.topic_string.ToUpper() + " WHERE Name = N'" + Program.nick_name + "'"));
        }

        private void picRestart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
                if (f.Name != "Main")
                    f.Close();
        }
    }
}

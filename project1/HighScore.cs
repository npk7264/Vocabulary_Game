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
    public partial class HighScore : Form
    {
        DataTable dt = new DataTable();

        public HighScore()
        {
            InitializeComponent();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nick name", typeof(string));
            dt.Columns.Add("Score", typeof(int));
            dgvHighScore.DataSource = dt;
        }

        private void cboTopic_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTopic.Text != null)
            {
                List<User> user = UserMethod.ReadFile(Application.StartupPath + "\\" + cboTopic.Text + "\\data.txt");
                user = user.OrderByDescending(o => o.Score).ToList();
                if (user.Count != 0)
                {
                    foreach (User u in user)
                    {
                        dt.Rows.Add(user.IndexOf(u) + 1, u.Name, u.Score);
                        dgvHighScore.DataSource = dt;
                    }
                }
            }
        }
    }
}

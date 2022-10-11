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
            cboTopic.Text = "ANIMAL";
        }

        private void cboTopic_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTopic.Text != null)
            {
                string sql;
                sql = "SELECT ROW_NUMBER() OVER (ORDER BY Score DESC, Time ASC) AS [Rank], Name, Score, Time FROM " + cboTopic.Text + " ORDER BY Score DESC";
                dt = Functions.GetDataToTable(sql);
                dgvHighScore.DataSource = dt;
                dgvHighScore.Columns[0].HeaderText = "Rank";
                dgvHighScore.Columns[1].HeaderText = "Name";
                dgvHighScore.Columns[2].HeaderText = "Score";
                dgvHighScore.Columns[3].HeaderText = "Time";
                dgvHighScore.Columns[0].Width = 80;
                dgvHighScore.Columns[1].Width = 200;
                dgvHighScore.Columns[2].Width = 100;
                dgvHighScore.Columns[3].Width = 100;
                dgvHighScore.AllowUserToAddRows = false;
                dgvHighScore.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }
    }
}

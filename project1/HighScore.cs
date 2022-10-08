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

        }

        private void cboTopic_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTopic.Text != null)
            {
                string sql;
                sql = "SELECT * FROM " + cboTopic.Text + " ORDER BY Score DESC";
                dt = Functions.GetDataToTable(sql);
                dgvHighScore.DataSource = dt;
                dgvHighScore.Columns[0].HeaderText = "Name";
                dgvHighScore.Columns[1].HeaderText = "Score";
                dgvHighScore.Columns[0].Width = 400;
                dgvHighScore.Columns[1].Width = 400;
                dgvHighScore.AllowUserToAddRows = false;
                dgvHighScore.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }
    }
}

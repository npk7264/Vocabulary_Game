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
    public partial class NickName : Form
    {
        public NickName()
        {
            InitializeComponent();
        }

        private void txtNickName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nickname = txtNickName.Text.Trim();

                if (nickname.Length == 0)
                {
                    MessageBox.Show("Invalid nick name!");
                    txtNickName.Text = null;
                }
                else
                {
                    this.Visible = false;
                    Program.nick_name = nickname;
                    Topic frm = new Topic();
                    frm.ShowDialog();

                }
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

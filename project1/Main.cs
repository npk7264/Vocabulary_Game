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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            WMP_music.URL = "music.mp3";
            WMP_music.settings.setMode("loop", true);
            Program.music = WMP_music;
            pnOption.Width = 994;
            pnOption.Height = 330;
            pnOption.Dock = DockStyle.Bottom;
            picStart.Anchor = AnchorStyles.None;
            picHighScore.Anchor = AnchorStyles.None;
            picVocabularyList.Anchor = AnchorStyles.None;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void picStart_Click(object sender, EventArgs e)
        {
            NickName frm = new NickName();
            frm.ShowDialog();
        }

        private void picVocabularyList_Click(object sender, EventArgs e)
        {
            Vocabulary frm = new Vocabulary();
            frm.ShowDialog();
        }

        private void picHighScore_Click(object sender, EventArgs e)
        {
            HighScore frm = new HighScore();
            frm.ShowDialog();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

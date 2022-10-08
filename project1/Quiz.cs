using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace project1
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        public string[] picture;
        string[] answer;

        public string[] fruit =
            {
            "apple",
            "banana",
            "grape",
            "cherry",
            "strawberry",
            "pineapple",
            "avocado",
            "kiwi",
            "orange",
            "watermelon"
        };
        public string[] animal =
        {
            "dolphin",
            "fox",
            "tiger",
            "lion",
            "rabbit",
            "duck",
            "cat",
            "bear",
            "eagle",
            "penguin"
        };


        int index; // vị trí xuất hiện bức ảnh trong mảng

        List<int> visited = new List<int>(); // vị trí các ảnh đã duyệt

        int score = 0; // số câu trả lời đúng
        int question = 1;

        private void Quiz_Load(object sender, EventArgs e)
        {
            picUnmute.Visible = false;
            picMute.Visible = true;

            // từ liệu từ form Topic
            if (Program.topic_string == "fruit")
                answer = fruit;
            else
                answer = animal;

            picture = new string[10];
            for (int i = 1; i <= 10; ++i)
                picture[i - 1] = Program.topic_string + "/" + i + ".png";

            // hiển thị ảnh ngẫu nhiên
            Random rnd = new Random();
            index = rnd.Next(0, 10);
            visited.Add(index);

            // hiển thị ảnh
            picQuiz.BackgroundImage = Image.FromFile(picture[index]);
            lbQuestion.Text = "QUESTION: " + question.ToString();
            lbScore.Text = "SCORE: " + score;
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInput.Text.Trim().ToLower() == answer[index])
                {
                    score += 2;
                    lbScore.Text = "SCORE: " + score;
                    pnQuestion.Visible = false;
                    pnResult.Visible = true;
                    picResult.BackgroundImage = Properties.Resources.like;
                }
                else
                {
                    pnResult.Visible = true;
                    picResult.BackgroundImage = Properties.Resources.wrong_answer;
                }
                //
                ++question;
                lbCorrectAnswer.Text = answer[index].ToUpper();
                pnQuestion.Visible = false;
                txtInput.Visible = false;
                pnMic.Visible = true;
                picNext.Visible = true;
                if (visited.Count == 5)
                    picNext.BackgroundImage = Properties.Resources.complete;
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            string sql;
            if (visited.Count < 5)
            {
                bool check;

                do
                {
                    check = true;

                    Random rnd = new Random();
                    index = rnd.Next(0, 10);

                    if (visited.Contains(index))
                        check = false;

                    if (check == true)
                    {
                        visited.Add(index);
                    }
                }
                while (check == false);
                picQuiz.BackgroundImage = Image.FromFile(picture[index]);
                lbQuestion.Text = "QUESTION: " + question.ToString();
                txtInput.Text = null;
                txtInput.Visible = true;
                txtInput.Focus();
                pnResult.Visible = false;
                picNext.Visible = false;
                pnMic.Visible = false;
                pnQuestion.Visible = true;
            }
            else // đã duyệt hết các bức ảnh
            {
                Program.nick_score = score;
                pnQuestion.Visible = false;
                pnResult.Visible = false;
                picNext.Visible = false;
                pnMic.Visible = false;
                int count = Convert.ToInt32(Functions.GetFieldValues("SELECT COUNT(Name) FROM " + Program.topic_string.ToUpper() + " WHERE Name = N'" + Program.nick_name.ToString() + "'"));
                if (count == 0)
                {
                    sql = "INSERT INTO " + Program.topic_string.ToUpper() + " VALUES (N'" + Program.nick_name + "'" + ", " + Program.nick_score.ToString() + ")";
                    Functions.RunSQL(sql);
                }
                else
                {
                    int flag = Convert.ToInt32(Functions.GetFieldValues("SELECT COUNT(Name) FROM " + Program.topic_string.ToUpper() + " WHERE Score < " + Program.nick_score));
                    if (flag > 0)
                    {
                        sql = "UPDATE " + Program.topic_string.ToUpper() + " SET Score = " + Program.nick_score + " WHERE Name = N'" + Program.nick_name + "'";
                        Functions.RunSQL(sql);
                    }
                }
                this.Close();
                Complete frm = new Complete();
                frm.ShowDialog();
            }
        }

        private void picMute_Click(object sender, EventArgs e)
        {
            picMute.Visible = false;
            picUnmute.Visible = true;
            Program.music.settings.volume = 0;
        }

        private void picUnmute_Click(object sender, EventArgs e)
        {
            picMute.Visible = true;
            picUnmute.Visible = false;
            Program.music.settings.volume = 50;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void picBack_Click(object sender, EventArgs e)
        {

        }

        private void picMic_Click(object sender, EventArgs e)
        {
            SpVoice obj = new SpVoice();
            obj.Speak(lbCorrectAnswer.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void pnMic_Click_1(object sender, EventArgs e)
        {
            SpVoice obj = new SpVoice();
            obj.Speak(lbCorrectAnswer.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}


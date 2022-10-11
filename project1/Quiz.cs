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
        public string[] food =
        {
            "salad",
            "ice cream",
            "soup",
            "bread",
            "biscuit",
            "pizza",
            "peanut",
            "cheese",
            "butter",
            "jam"
        };
        public string[] sport =
        {
            "soccer",
            "basketball",
            "tennis",
            "athletics",
            "baseball",
            "gymnastic",
            "cycling",
            "skiing",
            "golf",
            "skateboarding"
        };


        int index; // vị trí xuất hiện bức ảnh trong mảng

        List<int> visited = new List<int>(); // vị trí các ảnh đã duyệt

        int score = 0; // số câu trả lời đúng
        int question = 1;
        int timer_count = 0;

        private void Quiz_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Program.music.settings.volume = 50;
            picUnmute.Visible = false;
            picMute.Visible = true;

            // từ liệu từ form Topic
            if (Program.topic_string == "fruit")
                answer = fruit;
            else if (Program.topic_string == "animal")
                answer = animal;
            else if (Program.topic_string == "food")
                answer = food;
            else
                answer = sport;

            picture = new string[10];
            for (int i = 1; i <= 10; ++i)
                picture[i - 1] = Program.topic_string + "/" + i + ".png";

            // hiển thị ảnh ngẫu nhiên
            Random rnd = new Random();
            index = rnd.Next(0, 10);
            visited.Add(index);

            // hiển thị ảnh
            picQuiz.BackgroundImage = Image.FromFile(picture[index]);
            lbQuestion.Text = question.ToString();
            lbScore.Text = score.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++timer_count;
            lbTime.Text = timer_count.ToString();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInput.Text.Trim().ToLower() == answer[index])
                {
                    SpVoice obj = new SpVoice();
                    obj.Speak("Correct", SpeechVoiceSpeakFlags.SVSFDefault);
                    score += 2;
                    lbScore.Text = score.ToString();
                    pnQuestion.Visible = false;
                    pnResult.Visible = true;
                    picResult.BackgroundImage = Properties.Resources.like;
                }
                else
                {
                    SpVoice obj = new SpVoice();
                    obj.Speak("Incorrect", SpeechVoiceSpeakFlags.SVSFDefault);
                    pnResult.Visible = true;
                    picResult.BackgroundImage = Properties.Resources.wrong_answer;
                }
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
                lbQuestion.Text = question.ToString();
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
                timer1.Stop();
                Program.nick_score = score;
                pnQuestion.Visible = false;
                pnResult.Visible = false;
                picNext.Visible = false;
                pnMic.Visible = false;
                int count = Convert.ToInt32(Functions.GetFieldValues("SELECT COUNT(Name) FROM " + Program.topic_string.ToUpper() + " WHERE Name = N'" + Program.nick_name.ToString() + "'"));
                if (count == 0)
                {
                    sql = "INSERT INTO " + Program.topic_string.ToUpper() + " VALUES (N'" + Program.nick_name + "'" + ", " + Program.nick_score.ToString() + ", " + timer_count.ToString() + ")";
                    Functions.RunSQL(sql);
                }
                else
                {
                    int flag1 = Convert.ToInt32(Functions.GetFieldValues("SELECT COUNT(Name) FROM " + Program.topic_string.ToUpper() + " WHERE Score < " + Program.nick_score + " AND Name = N'" + Program.nick_name + "'"));
                    int flag2 = Convert.ToInt32(Functions.GetFieldValues("SELECT COUNT(Name) FROM " + Program.topic_string.ToUpper() + " WHERE Score = " + Program.nick_score + " AND Time > " + timer_count.ToString() + " AND Name = N'" + Program.nick_name + "'"));
                    if (flag1 > 0)
                    {
                        sql = "UPDATE " + Program.topic_string.ToUpper() + " SET Score = " + Program.nick_score + ", Time = " + timer_count.ToString() + " WHERE Name = N'" + Program.nick_name + "'";
                        Functions.RunSQL(sql);
                    }
                    else if (flag2 > 0)
                    {
                        sql = "UPDATE " + Program.topic_string.ToUpper() + " SET Time = " + timer_count.ToString() + " WHERE Name = N'" + Program.nick_name + "'";
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
            timer1.Stop();
            this.Close();
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

        private void picHome_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
                if (f.Name != "Main")
                    f.Close();
        }
    }
}


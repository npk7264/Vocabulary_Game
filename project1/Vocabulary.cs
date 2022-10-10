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
    public partial class Vocabulary : Form
    {
        public Vocabulary()
        {
            InitializeComponent();
        }

        private void Vocabulary_Load(object sender, EventArgs e)
        {
            cboTopic.Text = "Animal";
        }

        private void cboTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTopic.Text == "Animal")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("En", typeof(string));
                dt.Columns.Add("Vn", typeof(string));

                dt.Rows.Add("1", "Dolphin", "Cá heo");
                dt.Rows.Add("2", "Fox", "Cáo");
                dt.Rows.Add("3", "Tiger", "Hổ");
                dt.Rows.Add("4", "Lion", "Sư tử");
                dt.Rows.Add("5", "Rabbit", "Thỏ");
                dt.Rows.Add("6", "Duck", "Vịt");
                dt.Rows.Add("7", "Cat", "Mèo");
                dt.Rows.Add("8", "Bear", "Gấu");
                dt.Rows.Add("9", "Eagle", "Đại bàng");
                dt.Rows.Add("10", "Penguin", "Chim cánh cụt");

                dgvVocabulary.DataSource = dt;
                dgvVocabulary.Columns[0].Width = 100;
                dgvVocabulary.Columns[1].Width = 200;
                dgvVocabulary.Columns[2].Width = 200;
            }
            else if(cboTopic.Text == "Food")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("En", typeof(string));
                dt.Columns.Add("Vn", typeof(string));

                dt.Rows.Add("1", "Salad", "Rau trộn");
                dt.Rows.Add("2", "Ice cream", "Kem");
                dt.Rows.Add("3", "Soup", "Súp");
                dt.Rows.Add("4", "Bread", "Bánh mì");
                dt.Rows.Add("5", "Biscuit", "Bánh quy");
                dt.Rows.Add("6", "Pizza", "Bánh pizza");
                dt.Rows.Add("7", "Peanut", "Đậu phộng");
                dt.Rows.Add("8", "Cheese", "Phô mai");
                dt.Rows.Add("9", "Butter", "Bơ");
                dt.Rows.Add("10", "Jam", "Mứt");

                dgvVocabulary.DataSource = dt;
                dgvVocabulary.Columns[0].Width = 100;
                dgvVocabulary.Columns[1].Width = 200;
                dgvVocabulary.Columns[2].Width = 200;
            }
            else if(cboTopic.Text == "Fruit")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("En", typeof(string));
                dt.Columns.Add("Vn", typeof(string));

                dt.Rows.Add("1", "Apple", "Quả táo");
                dt.Rows.Add("2", "Banana", "Quả chuối");
                dt.Rows.Add("3", "Grape", "Quả nho");
                dt.Rows.Add("4", "Cherry", "Quả che-ri");
                dt.Rows.Add("5", "Strawberry", "Quả dâu tây");
                dt.Rows.Add("6", "Pineapple", "Quả khóm");
                dt.Rows.Add("7", "Avocado", "Quả bơ");
                dt.Rows.Add("8", "Kiwi", "Quả kiwi");
                dt.Rows.Add("9", "Orange", "Quả cam");
                dt.Rows.Add("10", "Watermelon", "Quả dưa hấu");

                dgvVocabulary.DataSource = dt;
                dgvVocabulary.Columns[0].Width = 100;
                dgvVocabulary.Columns[1].Width = 200;
                dgvVocabulary.Columns[2].Width = 200;
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("En", typeof(string));
                dt.Columns.Add("Vn", typeof(string));

                dt.Rows.Add("1", "Soccer", "Bóng đá");
                dt.Rows.Add("2", "Basketball", "Bóng rổ");
                dt.Rows.Add("3", "Tennis", "Quần vợt");
                dt.Rows.Add("4", "Athletics", "Điền kinh");
                dt.Rows.Add("5", "Baseball", "Bóng chày");
                dt.Rows.Add("6", "Gymnastic", "Thể dục dụng cụ");
                dt.Rows.Add("7", "Cycling", "Đạp xe");
                dt.Rows.Add("8", "Skiing", "Trượt tuyết");
                dt.Rows.Add("9", "Golf", "Đánh golf");
                dt.Rows.Add("10", "Skateboarding", "Lướt ván");

                dgvVocabulary.DataSource = dt;
                dgvVocabulary.Columns[0].Width = 100;
                dgvVocabulary.Columns[1].Width = 200;
                dgvVocabulary.Columns[2].Width = 200;
            }
        }
    }
}

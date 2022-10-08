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

            dataGridView1.DataSource = dt;
        }
    }
}

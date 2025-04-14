using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] days = { "Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък", "Събота", "Неделя" };
        private void btn1_Click(object sender, EventArgs e)
        {
            lst1.Sorted = false;
            txt1.Lines = days;
            lst1.Items.Clear();
            lst1.Items.AddRange(days);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string[] s = txt1.Lines;
            Array.Sort(s);
            txt1.Lines = s;
            lst1.Sorted = true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lst1.Items.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}

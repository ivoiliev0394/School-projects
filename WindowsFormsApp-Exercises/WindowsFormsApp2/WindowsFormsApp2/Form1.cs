using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl2.Text = "град Варна";
            lbl2.ForeColor = Color.Red;
            lbl2.BackColor = Color.Green;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            pic1.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.White;
            lbl2.ForeColor = Color.White;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            btn7.Enabled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn7.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn10.ForeColor = Color.Pink;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pic1.Top = pic1.Top - 4;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pic1.Left = pic1.Left + 6;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            pic1.Height += 5;
            pic1.Width += 5;
            //pic1.Height=pic1.Height+5;
           //pic1.Width=pic1.Width + 5;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            /*  pic1.Height -= 5;
                pic1.Width -= 5;
             */
            pic1.Height = pic1.Height - 5;
            pic1.Width = pic1.Width - 5;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

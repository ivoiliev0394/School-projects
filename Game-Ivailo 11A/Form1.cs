using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_Game_Ivailo_11A
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int n1 = 0;
        int n2 = 0;
        int p=5;

        public Form1()
        {
            InitializeComponent();
        }
        int LVL1()
        {
            return r.Next(1, 20);
        }
        int LVL2()
        {
            return r.Next(1, 50);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            do
            {
                p = p - 1;
                lbl4.Text = p.ToString();
            } while (p < 0);
            int b = Int32.Parse(txt1.Text);
            if (b == n2) 
            { MessageBox.Show("Позна числото!", "Поздрав", MessageBoxButtons.OK); btn3.Enabled = true;pic1.Visible = true; }
            else if (b < n2) MessageBox.Show("Не е това числото!"/*"Числото е по-голямо!"*/, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (b > n2) MessageBox.Show("Не е това числото!"/*"Числото е по-малко!"*/, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (p == 0) { MessageBox.Show("Числото е " + n2, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); pic2.Visible = true; }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Въведи число от 1 до 20";
            pic1.Visible = false;
            pic2.Visible = false;
            picBEGINNING.Visible = false;
            btn4.Enabled = false;
            btn2.Enabled = false;
            btn1.Enabled = true; 
            n1 = LVL1();
            p = 5; lbl4.Text = p.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Въведи число от 1 до 50";
            pic1.Visible = false;
            pic2.Visible = false;
            picBEGINNING.Visible = false;
            btn3.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = true;
            n2 = LVL2(); 
            p = 5; lbl4.Text = p.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            do
            {
                p = p - 1;
                lbl4.Text = p.ToString();
            } while (p < 0);   
            int a = Int32.Parse(txt1.Text);
            if (a == n1) 
            { MessageBox.Show("Позна числото!", "Поздрав", MessageBoxButtons.OK); btn4.Enabled = true; pic1.Visible=true; }
            else if (a < n1) MessageBox.Show("Числото е по-голямо!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (a > n1) MessageBox.Show("Числото е по-малко!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (p == 0) { MessageBox.Show("Числото е " + n1, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); pic2.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            pic1.Visible = false;
            pic2.Visible = false;
            picBEGINNING.Visible = true;
            btn4.Enabled = true; 
            btn3.Enabled = true;
            btn2.Enabled = true;
            btn1.Enabled = true;
            lbl4.Text = "-";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

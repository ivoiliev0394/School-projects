using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
                MessageBox.Show("Ne ste vuveli ime na uchenij!", "INFO");
            else if (lst1.Items.IndexOf(txt1.Text) != -1) 
                MessageBox.Show("Uchenika veche go ima", "INFO");
            else lst1.Items.Add(txt1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int a = lst1.Items.IndexOf(txt1.Text);
            if (a != -1) lst1.Items.RemoveAt(a);
            else MessageBox.Show("Nqma uchenik s takova ime", "INFO");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndex != -1)
                MessageBox.Show("Dnes shte izpitame" + lst1.Text + ".", "INFO");
            else MessageBox.Show("NE E IZBRAN UCHENIK", "INFO");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedIndex == -1 || cbo1.SelectedIndex == -1)
                MessageBox.Show("Markirai", "INFO");
            else label1.Text = lst1.Text + "  trenira " + cbo1.Text + ".";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}

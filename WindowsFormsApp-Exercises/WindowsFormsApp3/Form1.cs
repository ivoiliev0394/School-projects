using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        FontStyle fs = new FontStyle();
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fs = fs ^ FontStyle.Bold;
            lblR.Font = new Font(lblR.Font.Name, lblR.Font.Size, fs);
          
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fs = fs ^ FontStyle.Italic;
            lblR.Font = new Font(lblR.Font.Name, lblR.Font.Size, fs);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fs = fs ^ FontStyle.Underline;
            lblR.Font = new Font(lblR.Font.Name, lblR.Font.Size, fs);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblR.Font = new Font(lblR.Font.Name, lblR.Font.Size + 4);
            btn6.Enabled = true;
            if (lblR.Font.Size >= 72) btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblR.Font = new Font(lblR.Font.Name, lblR.Font.Size - 4);
            btn5.Enabled = true;
            if (lblR.Font.Size <= 8) btn6.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblR.Font = new Font(txt1.Text,lblR.Font.Size,fs);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}

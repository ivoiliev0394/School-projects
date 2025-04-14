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
    public partial class Form2 : Form
    {
        FontStyle fs = new FontStyle();
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblU.Font = new Font(cbo1.Text, lblU.Font.Size, fs);
        }

        private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblU.Font = new Font(lblU.Font.Name, int.Parse(cbo2.Text), fs);
        }

        private void cbo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo3.Text == "Bold") fs = FontStyle.Bold;
            else if (cbo3.Text == "Italic") fs = FontStyle.Italic;
            else if (cbo3.Text == "Underline") fs = FontStyle.Underline;
            lblU.Font = new Font(lblU.Font.Name, lblU.Font.Size, fs);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}

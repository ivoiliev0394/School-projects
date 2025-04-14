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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Do you want more information?", "Road sign", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dr==DialogResult.Yes)
            {
                lblI.Text = "Stop, look around and pass!";
                lblI.ForeColor = Color.Green;
                lblI.BackColor = Color.Yellow;
            }
            else
            {
                lblI.Text = "Road sings are important!";
                lblI.ForeColor = Color.Red;
                lblI.BackColor = Color.Black;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}

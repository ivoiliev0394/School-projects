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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Весел ли си?", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                pic1.Visible = true;
                pic2.Visible = false;
            }
            if (dr == DialogResult.No)
            {
                pic1.Visible = false;
                pic2.Visible = true;
            }
            if (dr == DialogResult.Cancel)
                {
                    pic1.Visible = false;
                    pic2.Visible = false;
                }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Напускане на приложението?", "Изход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

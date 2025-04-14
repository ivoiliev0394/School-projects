using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        FontStyle fs = new FontStyle();
        Random r = new Random();
        int maxN;
        private void btn1_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                lst1.Items.Add(r.Next(10, 31));
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            

            maxN = int.MinValue;
            for (int i = 0; i < 12; i++)
                if (maxN < Convert.ToInt32(lst1.Items[i]))
                    maxN = Convert.ToInt32(lst1.Items[i]);
            lbl2.Text = "Максималното число "+maxN.ToString()+" се намира на "+ lst1.Items.IndexOf(maxN)+" място!";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fs = fs ^ FontStyle.Italic;
            lbl1.Font = new Font(lbl1.Font.Name, lbl1.Font.Size, fs);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DialogResult k;
           k= MessageBox.Show("Искате ли да напуснете приложението ?", "Изход",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(k==DialogResult.Yes) Application.Exit();
            
        }
    }
}

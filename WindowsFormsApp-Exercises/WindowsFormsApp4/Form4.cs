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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        int minN;
        private void btnG_Click(object sender, EventArgs e)
        {


            lst1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                lst1.Items.Add(r.Next(1, 101));
            } 
            
        }
        
        private void btnM_Click(object sender, EventArgs e)
        {   
            minN = int.MaxValue;
            for (int i = 0; i < 10; i++)
                if (minN > Convert.ToInt32(lst1.Items[i]))
                    minN = Convert.ToInt32(lst1.Items[i]);
            lblR.Text = minN.ToString();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int a = lst1.Items.IndexOf(minN);
            lst1.Items.RemoveAt(a);
           lst1.Items.Insert(a, r.Next(1, 101));
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

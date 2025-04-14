using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        { //1ви вариант
            int a = int.Parse(txt1.Text);
            switch(a)
            {  
                case 0: lblR.Text = "нула"; break;
                case 1: lblR.Text = "едно";break;
                case 2: lblR.Text = "две"; break;
                case 3: lblR.Text = "три"; break;
                case 4: lblR.Text = "четири"; break;
                case 5: lblR.Text = "пет"; break;
                case 6: lblR.Text = "шест"; break;
                case 7: lblR.Text = "седем"; break;
                case 8: lblR.Text = "осем"; break;
                case 9: lblR.Text = "девет"; break;
                default:lblR.Text = "Не сте въвели цифра.";break;
            }
            //2 вариант е дадения в учебника :)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        ComboBox[] marks = new ComboBox[15];
        Label[] subjects = new Label[15];
        string[] names = { "БЕЛ", "Първи ЧЕ", "Втори ЧЕ", "Математика", "Информатика", "ИТ", "История",
            "География", "Философия", "Биология", "Физика", "Химия", "Музика", "ИИ", "ФВС" };
        public Form2()
        {
            InitializeComponent();
            for(int i=0;i<15;i++)
            {
                //razpolagane na labels
                subjects[i] = new Label();
                subjects[i].Parent = this;
                subjects[i].Top = 70 + (i % 8) * 50;
                subjects[i].Left = (i / 8) * 150 + 50;
                subjects[i].Text = names[i];
                subjects[i].AutoSize = true;
                // razpolagane na comboboxes
                marks[i] = new ComboBox();
                marks[i].Parent = this;
                marks[i].Width = 100;
                marks[i].Height = 25;
                marks[i].Top = subjects[i].Top + 20;
                marks[i].Left = subjects[i].Left;
                //suzdavane na spisuk
                for (int j = 2; j <= 6; j++) marks[i].Items.Add(j);
                if (i == 14) marks[i].Items.Add("освободен");
                marks[i].DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i].SelectedIndex == -1)
                {
                    MessageBox.Show("Има непопълнени оценки!", "Информация");
                    return;
                }
            }
            int sum = 0, num = 14;
            for (int i = 0; i < 14; i++)
            {
                sum = sum + int.Parse(marks[i].Text);
            }
            if (marks[14].Text != "освободен")
            {
                sum = sum + int.Parse(marks[14].Text);
                num = 15;
            }
            double average = (double)sum / num;
            //textBox1.Text = Math.Round(average, 2).ToString();
            textBox1.Text = string.Format("{0:F2}", average);
        }
    }
}

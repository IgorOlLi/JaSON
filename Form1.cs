using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JaSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Очистка листбокса
            listBox1.Items.Clear();
            //Создание экземпляра DateTime
            DateTime fri = new DateTime(Convert.ToInt32(textBox1.Text), 1, 13);
            //Создание экземпляра List
            List<string> amogus = new List<string>();
            for (int i = 0; i <= 12; i++)
            {
                fri = fri.AddMonths(1);
                string s1 = fri.ToString("d dddd");
                Regex regex = new Regex(@"13 пят(\w*)");
                MatchCollection matches = regex.Matches(s1);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        amogus.Add(fri.ToString("d MMMM"));
                    }
                }
            }
            //Вывод дат в листбокс
            foreach (var sussy in amogus)
            {
                listBox1.Items.Add(sussy);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1, y = 99;
            int g = Convert.ToInt32(id.Text);
            if (g < x)
            {
                MessageBox.Show("значение не может быть меньше 1 или больше 99", "Ошибка");
            }
            else if (g > y)
            {
                MessageBox.Show("значение не может быть меньше 1 или больше 99", "Ошибка");
            }
            else
            {
                Form2 s = new Form2();
                s.Show();
                s.Owner = this;
            }
            
        }
    }
}

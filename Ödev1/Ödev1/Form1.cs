using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Bir Değer Giriniz!");
            }
            else
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                if (Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("0'dan Küçük Sayı Yazılamaz!");
                }
                else
                {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    if (i % 7 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                for (int j = sayi1; j < sayi2; j++)
                {
                    if (j % 9 == 0)
                    {
                        listBox2.Items.Add(j);
                    }
                }
                }

            }
        }
    }
}

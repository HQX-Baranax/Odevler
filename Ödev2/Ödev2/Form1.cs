using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int sayi1, sayi2, toplam = 0;
            int toplamcift = 0;
            int toplamtek = 0;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = true;
                MessageBox.Show("Bir Değer Giriniz!");
            }
            else
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("0'dan Küçük Değer Girilemez!");
                }
                else
                {
                    for (int a = sayi1; a <= sayi2; a++)
                    {
                        listBox6.Items.Add(a);
                    }
                    for (int b = sayi1; b <= sayi2; b++)
                    {
                        if (b % 2 == 0)
                        {
                            listBox2.Items.Add(b);
                        }
                        else
                        {
                            listBox1.Items.Add(b);
                        }
                    }
                    for (int c = sayi1; c <= sayi2; c++)
                    {
                        toplam += c;
                    }
                    listBox3.Items.Add(toplam);
                    for (int d = sayi1; d <= sayi2; d++)
                    {
                        if (d % 2 == 0)
                        {
                            toplamcift += d;
                        }
                    }
                    listBox5.Items.Add(toplamcift);
                    for (int f = sayi1; f <= sayi2; f++)
                    {
                        if(f % 2 == 0)
                        { 
                        }
                        else
                        {
                            toplamtek += f;
                        }
                    }
                    listBox4.Items.Add(toplamtek);
                }
                if (button1.Enabled == false)
                {
                    label9.Text = "Hesapla Butonunun Açılması İçin Temizle Butonuna Bas!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (button1.Enabled == true)
            {
                label9.Text = "";
            }
            textBox1.ResetText();
            textBox2.ResetText();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = (int)numericUpDown1.Value;
            int sayac = 0;
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");
            }
            else
            {
                while (sayi > 0)
                {
                    sayi /= 10;
                    sayac++;
                }
                sonuclbl.Text = sayac.ToString();

                label5.Text = "Girdiğiniz Sayı";
                label6.Text = "Basamaklıdır";
                uyarilbl.Text = "Tekrar Hesaplama Yapmak İçin Lütfen Temizle Butonunu Kullan!";
                button1.Enabled = false;
                numericUpDown1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;

            sonuclbl.Text = "";
            label5.Text = "";
            label6.Text = "";
            uyarilbl.Text = "";
            button1.Enabled = true;
            numericUpDown1.Enabled = true;
        }
    }
}

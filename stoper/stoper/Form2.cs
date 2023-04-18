using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoper
{
    public partial class Form2 : Form
    {
        Random jakasliczba = new Random();
        int liczba = 0;
        int zgadniecie = 0;
        public Form2()
        {
            InitializeComponent();
            zaladujpytanie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            zgadniecie += 1;
            if (x == liczba)
            {
                MessageBox.Show("Gratulacje, zgadłeś! Spróbuj jeszcze raz");
                zaladujpytanie();
                textBox1.Text = "";
                zgadniecie = 0;
            }
            else if (x < liczba)
            {
                MessageBox.Show("Liczba jest wyższa!");
            }
            else
            {
                MessageBox.Show("Liczba jest mniejsza!");
            }
        }
        private void zaladujpytanie()
        {
            liczba = jakasliczba.Next(0,100);
            label1.Text = "Jest to liczba pomiędzy 0 a 100!";
        }
    }
}

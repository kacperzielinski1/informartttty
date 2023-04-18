using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_ID.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dobrehaslo = textBox_ID.Text;

            if (dobrehaslo=="1234")
            {
                Form2 okienko = new Form2();
                okienko.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Podano złe ID!");
                Application.Exit();
            }

        }
    }
}

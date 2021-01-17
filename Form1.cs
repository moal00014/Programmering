using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int tries = 0;
        int rng = 0;
        int tal = 0;

        public Form1()
        {
            InitializeComponent();
            Random rd = new Random();
            rng = rd.Next(1, 101);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tal = Convert.ToInt32(textBox1.Text);
            tries++;
            label3.Text = "Antal gissningar: " + tries;

            if (tal < rng)
                label2.Text = ("Högre");

            else if (tal > rng)
                label2.Text = "Mindre";

            else
                label2.Text = "Du gissade rätt! ";
                
            if(tal == rng)
                label1.Text = "Grattis";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

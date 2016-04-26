using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

            double number;
            double percent;
            double.TryParse(textBox1.Text,out number);
            double.TryParse(textBox2.Text, out percent);

            double tip = number * (percent / 100);
            label2.Text = "" + tip;
            label3.Text = "" + (tip + number);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

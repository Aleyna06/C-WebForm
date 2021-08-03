using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Aleyna ÇELİK";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "20";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "05511045713";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label9.Text = textBox3.Text;
            comboBox1.Items.Add("ANKARA");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

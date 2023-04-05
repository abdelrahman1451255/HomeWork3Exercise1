using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork3Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1Title.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = textBoxFirstName.Text +" "+ textBoxLastName.Text;
           // textBoxFirstName.AppendText(textBoxFirstName.Text + " " + textBoxLastName.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Title.Visible = !Title.Visible;
            textBox1Title.Visible = !textBox1Title.Visible;
            button1.Visible = !button1.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1Title.Focus();
        }

        private void AJAX(object sender, EventArgs e)
        {
            textBoxFirstName.AppendText(textBoxFirstName.Text + " " + textBoxLastName.Text);

        }

        private void button5_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

            textBoxFullName.Text = textBoxFirstName.Text + " " + textBoxLastName.Text;

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

            textBoxFullName.Text = textBoxFirstName.Text + " " + textBoxLastName.Text;
        }
    }
}

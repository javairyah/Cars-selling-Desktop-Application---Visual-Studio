using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6 f6 = new Form6(); //this is the change, code for redirect  
            f6.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9(); //this is the change, code for redirect  
            f9.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form28 f28 = new Form28(); //this is the change, code for redirect  
            f28.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String message = "DETAILS:\n";

            if (textBox3.Text != "")
            {
                message = message + "\nFIRST NAME: " + textBox3.Text;
            }
            if (textBox4.Text != "")
            {
                message = message + "\nLAST NAME: " + textBox4.Text;
            }
            if (textBox5.Text != "")
            { 
                message = message + "\nEMAIL: " + textBox5.Text;
            }
            if (textBox6.Text != "")
            {
                message = message + "\nPASSWORD: " + textBox6.Text;
            }
            if (textBox7.Text != "")
            {
                message = message + "\nPHONE NUMBER: " + textBox7.Text;
            }
            MessageBox.Show(message, "SIGN UP");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }
    }
}

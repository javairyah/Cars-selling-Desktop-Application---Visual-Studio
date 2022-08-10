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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(); //this is the change, code for redirect  
            f3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(); //this is the change, code for redirect  
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(); //this is the change, code for redirect  
            f5.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(); //this is the change, code for redirect  
            f6.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(); //this is the change, code for redirect  
            f8.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(); //this is the change, code for redirect  
            f8.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9(); //this is the change, code for redirect  
            f9.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form28 f28 = new Form28(); //this is the change, code for redirect  
            f28.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
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

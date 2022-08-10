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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(); //this is the change, code for redirect  
            f8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10(); //this is the change, code for redirect  
            f10.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form28 f28 = new Form28(); //this is the change, code for redirect  
            f28.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 f16 = new Form16(); //this is the change, code for redirect  
            f16.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form22 f22 = new Form22(); //this is the change, code for redirect  
            f22.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }
    }
}

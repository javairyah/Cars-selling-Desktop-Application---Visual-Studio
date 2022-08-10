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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(); //this is the change, code for redirect  
            f8.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(); //this is the change, code for redirect  
            f8.ShowDialog();
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

        private void button12_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form28 f28 = new Form28(); //this is the change, code for redirect  
            f28.ShowDialog();
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";

        private void button6_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numericUpDown1.Value);
            if (numericUpDown1.Value > 0)
            {
                double price = 10000000;
                double Result = price * value;
                SetValueForText1 = label3.Text;
                SetValueForText2 = Convert.ToString(numericUpDown1.Value);
                SetValueForText3 = Convert.ToString(price);
                SetValueForText4 = Convert.ToString(Result);
                this.Hide();
                Form28 f28 = new Form28(); //this is the change, code for redirect  
                f28.ShowDialog();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

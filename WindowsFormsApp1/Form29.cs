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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form28 f28 = new Form28(); //this is the change, code for redirect  
            f28.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)

        {
          

            String message =   "ITEMS      \t"  +"QUANTITY      \t"  + "PRICE                \n";
            if(message != "")
                { 
                message = message + "\n" + Form28.SetValueForText1 + "                               \t" + Form28.SetValueForText2 + "\t" + Form28.SetValueForText3;
                message = message + "\n" + Form16.SetValueForText5 + "\t" + Form16.SetValueForText6 + "\t" + Form16.SetValueForText7;
                message = message + "\n" + Form22.SetValueForText8 + "             \t" + Form22.SetValueForText9 + "\t" + Form22.SetValueForText10 +"\n";

            }
            if (message != "")
            {
                message = message + "\nYOUR RECEIPT:"+"\n";
            }

            if (textBox3.Text != "")
            {
                message = message + "\nFULL NAME: " + textBox3.Text ;
            }
            if (textBox4.Text != "")
            {
                message = message + "\nADDRESS: " + textBox4.Text ;
            }
            if (textBox5.Text != "")
            {
                message = message + "\nCITY: " + textBox5.Text ;
            }
            if (textBox6.Text != "")
            {
                message = message + "\nEMAIL: " + textBox6.Text ;
            }
            if (textBox7.Text != "")
            {
                message = message + "\nCONTACT: " + textBox7.Text ;
            }
            if (message != "")
            {
                message = message + "\nTOTAL AMOUNT: " + Form28.SetValueForText4+"\n";
            }
           
            MessageBox.Show(message, "THANK YOU FOR YOUR ORDER!");
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(); //this is the change, code for redirect  
            f6.ShowDialog();
        }

        private void Form29_Load(object sender, EventArgs e)
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

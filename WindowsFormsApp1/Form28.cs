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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
            
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            //car
           
                textBox3.Text = Form10.SetValueForText1;
                textBox4.Text = Form10.SetValueForText2;
                textBox5.Text = Form10.SetValueForText3;
                textBox6.Text = Form10.SetValueForText4;
           


                //textBox3.Text = Form11.SetValueForText1;
                //textBox4.Text = Form11.SetValueForText2;
                //textBox5.Text = Form11.SetValueForText3;
                //textBox6.Text = Form11.SetValueForText4;
           

                //textBox3.Text = Form12.SetValueForText1;
                //textBox4.Text = Form12.SetValueForText2;
                //textBox5.Text = Form12.SetValueForText3;
                //textBox6.Text = Form12.SetValueForText4;
           
                //textBox3.Text = Form13.SetValueForText1;
                //textBox4.Text = Form13.SetValueForText2;
                //textBox5.Text = Form13.SetValueForText3;
                //textBox6.Text = Form13.SetValueForText4;
           
                //textBox3.Text = Form14.SetValueForText1;
                //textBox4.Text = Form14.SetValueForText2;
                //textBox5.Text = Form14.SetValueForText3;
                //textBox6.Text = Form14.SetValueForText4;
           
                //textBox3.Text = Form15.SetValueForText1;
                //textBox4.Text = Form15.SetValueForText2;
                //textBox5.Text = Form15.SetValueForText3;
                //textBox6.Text = Form15.SetValueForText4;
            
            //bike


            textBox7.Text = Form16.SetValueForText5;
            textBox8.Text = Form16.SetValueForText6;
            textBox9.Text = Form16.SetValueForText7;
            textBox10.Text = Form16.SetValueForText4;

            //textBox7.Text = Form17.SetValueForText1;
            //textBox8.Text = Form17.SetValueForText2;
            //textBox9.Text = Form17.SetValueForText3;
            //textBox10.Text = Form17.SetValueForText4;

            //textBox7.Text = Form18.SetValueForText1;
            //textBox8.Text = Form18.SetValueForText2;
            //textBox9.Text = Form18.SetValueForText3;
            //textBox10.Text = Form18.SetValueForText4;

            //textBox7.Text = Form19.SetValueForText1;
            //textBox8.Text = Form19.SetValueForText2;
            //textBox9.Text = Form19.SetValueForText3;
            //textBox10.Text = Form19.SetValueForText4;

            //textBox7.Text = Form20.SetValueForText1;
            //textBox8.Text = Form20.SetValueForText2;
            //textBox9.Text = Form20.SetValueForText3;
            //textBox10.Text = Form20.SetValueForText4;

            //textBox7.Text = Form21.SetValueForText1;
            //textBox8.Text = Form21.SetValueForText2;
            //textBox9.Text = Form21.SetValueForText3;
            //textBox10.Text = Form21.SetValueForText4;

            //jeep

            textBox11.Text = Form22.SetValueForText8;
            textBox12.Text = Form22.SetValueForText9;
            textBox13.Text = Form22.SetValueForText10;
            textBox14.Text = Form22.SetValueForText4;

            //textBox11.Text = Form23.SetValueForText1;
            //textBox12.Text = Form23.SetValueForText2;
            //textBox13.Text = Form23.SetValueForText3;
            //textBox14.Text = Form23.SetValueForText4;

            //textBox11.Text = Form24.SetValueForText1;
            //textBox12.Text = Form24.SetValueForText2;
            //textBox13.Text = Form24.SetValueForText3;
            //textBox14.Text = Form24.SetValueForText4;

            //textBox11.Text = Form25.SetValueForText1;
            //textBox12.Text = Form25.SetValueForText2;
            //textBox13.Text = Form25.SetValueForText3;
            //textBox14.Text = Form25.SetValueForText4;

            //textBox11.Text = Form26.SetValueForText1;
            //textBox12.Text = Form26.SetValueForText2;
            //textBox13.Text = Form26.SetValueForText3;
            //textBox14.Text = Form26.SetValueForText4;

            //textBox11.Text = Form27.SetValueForText1;
            //textBox12.Text = Form27.SetValueForText2;
            //textBox13.Text = Form27.SetValueForText3;
            //textBox14.Text = Form27.SetValueForText4;

            //calculation

            decimal value1 = 0;
            decimal value2 = 0;
            decimal value3 = 0;
      

            decimal.TryParse(textBox6.Text, out value1);
            decimal.TryParse(textBox10.Text, out value2);
            decimal.TryParse(textBox14.Text, out value3);

            decimal price = (value1 + value2 + value3);
            textBox15.Text =  price.ToString();

            

    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
        public static string SetValueForText5 = "";
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3 != null && textBox4 != null && textBox5 != null && textBox6 != null)
            {
                SetValueForText1 = Convert.ToString(textBox3.Text);
                SetValueForText2 = Convert.ToString(textBox4.Text);
                SetValueForText3 = Convert.ToString(textBox5.Text);
                SetValueForText4 = Convert.ToString(textBox6.Text);
            }
            else if (textBox7 != null && textBox8 != null && textBox9 != null && textBox10 != null)
            {
                SetValueForText1 = Convert.ToString(textBox7.Text);
                SetValueForText2 = Convert.ToString(textBox8.Text);
                SetValueForText3 = Convert.ToString(textBox9.Text);
                SetValueForText4 = Convert.ToString(textBox10.Text);
            }
            else
            {
                SetValueForText1 = Convert.ToString(textBox11.Text);
                SetValueForText2 = Convert.ToString(textBox12.Text);
                SetValueForText3 = Convert.ToString(textBox13.Text);
                SetValueForText4 = Convert.ToString(textBox14.Text);
            }
            SetValueForText5 = Convert.ToString(textBox15.Text);
            this.Hide();
            Form29 f29 = new Form29(); //this is the change, code for redirect  
            f29.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6 f6 = new Form6(); //this is the change, code for redirect  
            f6.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9(); //this is the change, code for redirect  
            f9.ShowDialog();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }
    }
}

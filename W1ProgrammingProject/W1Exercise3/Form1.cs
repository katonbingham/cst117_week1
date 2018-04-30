using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1Exercise3
{
    public partial class Form1 : Form
    {
        public static string passingTextLbs = "0";
        public static string passingTextKg = "0";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            decimal userInputDecimal = Convert.ToDecimal(userInput);                       // convert input from string to decimal
            decimal junkDecimal = decimal.Multiply(userInputDecimal, 0.45359237m);         // perform arithmetic 
            junkDecimal = decimal.Round(junkDecimal, 3);                                   // round to 3 decimal places
            passingTextLbs = junkDecimal.ToString();                                       // convert to string to display
            textBox3.Text = passingTextLbs;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
             
            string userInput = textBox2.Text;
            decimal userInputDecimal = Convert.ToDecimal(userInput);                       // convert input from string to decimal
            decimal junkDecimal = decimal.Multiply(userInputDecimal, 2.2046226218488m);    // perform arithmetic 
            junkDecimal = decimal.Round(junkDecimal, 3);                                   // round to 3 decimal places
            passingTextLbs = junkDecimal.ToString();                                       // convert to string to display
            textBox4.Text = passingTextLbs;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {   

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

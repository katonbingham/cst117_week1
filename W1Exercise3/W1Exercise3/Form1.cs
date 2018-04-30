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
            // declare variables
            string userInput = textBox1.Text;

            // convert string with "123" into integer holding 123
            Double userInputDouble = Convert.ToDouble(userInput);

            // perform conversion
            Double junk = userInputDouble * 0.45359237;

            /* lbs *  0.45359237 = x kilos             
             * kilos * 2.2046226218488 = y lbs
             */

            // assign passingText to new value
            passingTextKg = junk.ToString();
            textBox3.Text = passingTextKg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // declare variables
            string userInput = textBox2.Text;

            // convert string with "123" into integer holding 123
            Double userInputDouble = Convert.ToDouble(userInput);

            // perform conversion
            Double junk = userInputDouble * 2.2046226218488;

            /* lbs *  0.45359237 = x kilos             
             * kilos * 2.2046226218488 = y lbs
             */

            // assign passingText to new value
            passingTextLbs = junk.ToString();
            textBox4.Text = passingTextLbs;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

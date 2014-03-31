using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PiotrSemberecki_Lab1Zad1
{
    public partial class Form1 : Form
    {
        String display = "";
        double a;
        double b;
        char operation;
        public Form1()
        {
            InitializeComponent();
        }
        #region Digit Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            display += "1";
            textBoxDisplay.Text = display;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            display += "2";
            textBoxDisplay.Text = display;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display += "3";
            textBoxDisplay.Text = display;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display += "4";
            textBoxDisplay.Text = display;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display += "5";
            textBoxDisplay.Text = display;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display += "6";
            textBoxDisplay.Text = display;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display += "7";
            textBoxDisplay.Text = display;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display += "8";
            textBoxDisplay.Text = display;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display += "9";
            textBoxDisplay.Text = display;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display += "0";
            textBoxDisplay.Text = display;
        }
        #endregion
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(display);
            display += " +";
            textBoxDisplayA.Text = display;
            display = "";
            textBoxDisplay.Text = "";
            operation = '+';

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(display);
            display = "";
            textBoxDisplayA.Text = "";
            if (operation == '+')
            {
                textBoxDisplay.Text = Convert.ToString(a + b);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            display += ".";
            textBoxDisplay.Text = display;
        }


    }
}

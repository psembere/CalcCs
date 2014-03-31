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
        double a = 0;
        double b = 0; 
        char operation;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(Form1_KeyPress);
        }
        private void set_Digit(String s)
        {
            display += s;
            textBoxDisplay.Text = display;
        }
        #region Digit Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            this.set_Digit("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.set_Digit("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.set_Digit("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.set_Digit("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.set_Digit("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.set_Digit("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.set_Digit("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.set_Digit("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.set_Digit("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.set_Digit("0");
        }
        private void buttonComma_Click(object sender, EventArgs e)
        {
            this.set_Digit(".");
        }
        #endregion
        
        public void operationSet(Char cc)
        {
            if (a == 0)
                a = Convert.ToDouble(display);
            else
                display = Convert.ToString(a);

            display += " " + cc;
            textBoxDisplayA.Text = display;
            display = "";
            textBoxDisplay.Text = "";
            operation = cc;
        }

        #region operations
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.operationSet('+');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.operationSet('-');
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.operationSet('*');
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.operationSet('/');
        }
        #endregion
        public void operationEquals()
        {
            b = Convert.ToDouble(display);
            textBoxDisplay.Text = "";
            switch (operation)
            {
                case '+':
                    a = a + b;
                    break;
                case '-':
                    a = a - b;
                    break;
                case '*':
                    a = a * b;
                    break;
                case '/':
                    a = a / b;
                    break;
            }
            char o = operation;
            if ((o == '+') || (o == '-') || (o == '*') || (o == '/'))
            {
                textBoxDisplayA.Text = Convert.ToString(a);
                b = 0;
                display = "";
                operation = ' ';
            }
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operationEquals();

        }
        private void clear()
        {
            display = "";
            textBoxDisplayA.Text = "";
            textBoxDisplay.Text = "";
            operation = ' ';
            a = 0;
            b = 0;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

     

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                switch (e.KeyChar)
                {
                    case (char)48:
                        this.set_Digit("0");
                        break;
                    case (char)49:
                        this.set_Digit("1");
                         break;
                    case (char)50:
                         this.set_Digit("2");
                         break;
                    case (char)51:
                         this.set_Digit("3");
                         break;
                    case (char)52:
                         this.set_Digit("4");
                         break;
                    case (char)53:
                         this.set_Digit("5");
                         break;
                    case (char)54:
                         this.set_Digit("6");
                         break;
                    case (char)55:
                         this.set_Digit("7");
                         break;
                    case (char)56:
                         this.set_Digit("8");
                         break;
                    case (char)57:
                         this.set_Digit("9");
                         break;
                    case (char)61:
                         this.operationEquals();
                         break;
                    case (char)46:
                         this.set_Digit(".");
                         break;
                    case (char)43: 
                         this.operationSet('+');
                         break;
                    case (char)45: 
                         this.operationSet('-');
                         break;
                    case (char)42:
                         this.operationSet('*');
                         break;
                    case (char)47:
                         this.operationSet('/');
                         break;
                }
            
        }

    }
}

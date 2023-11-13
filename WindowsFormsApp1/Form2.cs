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

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;




        private void numberDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button6.Text;

        }


        private void button7_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button9.Text;

        }
        private void button0_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text + button0.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(numberDisplay.Text);
            numberDisplay.Clear();


        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(numberDisplay.Text);
            numberDisplay.Clear();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            option = "x";
            num1 = int.Parse(numberDisplay.Text);
            numberDisplay.Clear();

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(numberDisplay.Text);
            numberDisplay.Clear();

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            numberDisplay.Clear();
            result = 0;

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(numberDisplay.Text);
            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("x"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            numberDisplay.Text = result + "";
        }


    }
}

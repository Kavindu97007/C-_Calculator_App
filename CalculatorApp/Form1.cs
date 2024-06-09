using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        string operation = "";
        double resultValue;
        bool IsFunctionStatus = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {

            if(textBoxResult.Text == "0" || IsFunctionStatus)
            {
                textBoxResult.Clear();
            }

            Button btn = (Button)sender;

            if(btn.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                {
                    textBoxResult.Text = textBoxResult.Text + btn.Text;
                }

            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + btn.Text;

            }

            
            IsFunctionStatus = false;
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void operationFunctions(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                resultValue = Convert.ToDouble(textBoxResult.Text);
                labelResult.Text = resultValue + operation;
                IsFunctionStatus = true;
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                resultValue = Convert.ToDouble(textBoxResult.Text);
                labelResult.Text = resultValue + operation;
                IsFunctionStatus = true;
            }
            

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            labelResult.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;

                case "-":
                    textBoxResult.Text = (resultValue - Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;

                case "/":
                    textBoxResult.Text = (resultValue / Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;

                case "x":
                    textBoxResult.Text = (resultValue * Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;

            }

            resultValue = Convert.ToDouble(textBoxResult.Text);
            operation = "";
        }
    }
}

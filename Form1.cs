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
    public partial class Calculator : Form
    {


        private double _answer;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    _answer = Convert.ToDouble(FirstNumberInput.Text) + Convert.ToDouble(SecondNumberInput.Text);


        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    _answer = Convert.ToDouble(FirstNumberInput.Text) - Convert.ToDouble(SecondNumberInput.Text);

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    _answer = Convert.ToDouble(FirstNumberInput.Text) * Convert.ToDouble(SecondNumberInput.Text);

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    _answer = Convert.ToDouble(FirstNumberInput.Text) / Convert.ToDouble(SecondNumberInput.Text);

        //}


        private void button_Calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_answer.ToString());
        }


        private void Calculate(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    _answer = Convert.ToDouble(FirstNumberInput.Text) + Convert.ToDouble(SecondNumberInput.Text);
                    break;
                case "-":
                    _answer = Convert.ToDouble(FirstNumberInput.Text) - Convert.ToDouble(SecondNumberInput.Text);
                    break;
                case "*":
                    _answer = Convert.ToDouble(FirstNumberInput.Text) * Convert.ToDouble(SecondNumberInput.Text);
                    break;
                case "/":
                    _answer = Convert.ToDouble(FirstNumberInput.Text) / Convert.ToDouble(SecondNumberInput.Text);
                    break;
                default:
                    MessageBox.Show("Incorrects math operator");
                    break;
            }


        }
    }
}
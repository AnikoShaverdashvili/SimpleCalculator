﻿using System;
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


        private int _answer;
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

        private void button1_Click(object sender, EventArgs e)
        {
             _answer = Convert.ToInt32(FirstNumberInput.Text) + Convert.ToInt32(SecondNumberInput.Text);


        }
        private void button2_Click(object sender, EventArgs e)
        {
             _answer = Convert.ToInt32(FirstNumberInput.Text) - Convert.ToInt32(SecondNumberInput.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
             _answer = Convert.ToInt32(FirstNumberInput.Text) * Convert.ToInt32(SecondNumberInput.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
             _answer = Convert.ToInt32(FirstNumberInput.Text) / Convert.ToInt32(SecondNumberInput.Text);

        }


        private void button_Calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_answer.ToString());
        }
    }
}
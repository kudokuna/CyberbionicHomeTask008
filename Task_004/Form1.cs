using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_004
{
    public partial class Form1 : Form
    {
        double firstValue = default;
        double secondValue = default;
        string result = default;

        public Form1()
        {
            InitializeComponent();
           
        }


        static double GetDevisionRest(double firstValue, double secondValue) 
        {
            return firstValue % secondValue;
        }

        static double Exponentiation(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,secondValue);
        }

        static string Cancatination (double firstValue, double secondValue)
        {
             return $"{firstValue}{secondValue}";
        }

        string Division (double firstValue, double secondValue)
        {
            if (secondValue == 0) 
            {
                return "Cant devide by zero";
            }
            return (firstValue/secondValue).ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) 
                {
                    textBox3.Text = result;
                } else MessageBox.Show("Please, select operation");

                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             firstValue = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             secondValue = double.Parse(textBox2.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            result = GetDevisionRest(firstValue, secondValue).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            result = Exponentiation(firstValue, secondValue).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            result = Cancatination(firstValue, secondValue);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            result = Division(firstValue, secondValue);
        }
    }
}

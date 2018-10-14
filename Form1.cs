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
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            double result = firstNumber + secondNumber;

            resultTextBox.Text = result.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Text = "";
            resultTextBox.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            string checkedString = "";

            if (javaCheckBox.Checked)
            {
                checkedString += "Java,";
            }
            if (cSharpCheckBox.Checked)
            {
                checkedString += "C#,";
                
            }
            if (pythonCheckBox.Checked)
            {
                checkedString += "Python,";
            }

            checkedString = checkedString.Substring(0, checkedString.Length - 1);
            MessageBox.Show(checkedString+" is checked");

        }

        private void addListBoxButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            nameListBox.Items.Add(name);
        }

        private void clearListBoxButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
        }
    }
}

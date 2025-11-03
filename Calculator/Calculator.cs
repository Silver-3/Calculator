using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void EqualsButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (OutputTextBox.Text.EndsWith(" ")) return;

            string equation = OutputTextBox.Text;
            if (equation.Contains('x')) equation = equation.Replace('x', '*');
            if (equation.Contains('÷')) equation = equation.Replace('÷', '/');

            equation = Regex.Replace(equation, @"(\d+)²", "($1*$1)");

            var result = new DataTable().Compute(equation, null);
            OutputTextBox.Text = result.ToString();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (OutputTextBox.Text.EndsWith("²")) return;
            else if (OutputTextBox.Text == "0" && button.Text != ".") OutputTextBox.Text = $" {button.Text}";
            else if (OutputTextBox.Text.EndsWith(" ") && button.Text == ".") OutputTextBox.Text += "0.";
            else OutputTextBox.Text += button.Text;
        }

        private void OperationButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (OutputTextBox.Text.EndsWith(" ")) return;
            OutputTextBox.Text += $" {button.Text} ";
        }

        private void BackspaceButton_Clicked(object sender, EventArgs e)
        {
            if (OutputTextBox.Text.EndsWith(" "))
            {
                OutputTextBox.Text = OutputTextBox.Text.Remove(OutputTextBox.Text.Length - 3);
            }
            else
            {
                OutputTextBox.Text = OutputTextBox.Text.Remove(OutputTextBox.Text.Length - 1);
            }
        }

        private void CButton_Clicked(object sender, EventArgs e)
        {
            OutputTextBox.Text = "0";
        }

        private void NegativeButton_Clicked(object sender, EventArgs e)
        {
            if (OutputTextBox.Text.EndsWith("-")) OutputTextBox.Text = OutputTextBox.Text.Remove(OutputTextBox.Text.Length - 1);
            else if (!OutputTextBox.Text.EndsWith(" ")) return;
            else OutputTextBox.Text += "-";
        }

        private void SquaredButton_Clicked(object sender, EventArgs e)
        {
            if (OutputTextBox.Text.EndsWith(" ") || OutputTextBox.Text.EndsWith("-")) return;
            OutputTextBox.Text += "²";
        }
    }
}
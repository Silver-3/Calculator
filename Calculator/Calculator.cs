using System;
using System.Data;

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

            string expression = OutputTextBox.Text;
            if (expression.Contains('x')) expression = expression.Replace('x', '*');
            if (expression.Contains('÷')) expression = expression.Replace('÷', '/');

            var result = new DataTable().Compute(expression, null);
            OutputTextBox.Text = result.ToString();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (OutputTextBox.Text == "0" && button.Text != ".") OutputTextBox.Text = $" {button.Text}";
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
    }
}
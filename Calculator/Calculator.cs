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
            if (OutputTextBox.Text.EndsWith(" ")) return;
            string equation = OutputTextBox.Text;

            equation = equation.Replace('x', '*').Replace('÷', '/');
            equation = Regex.Replace(equation, @"(\d+(\.\d+)?)²", "($1*$1)");

            while (Regex.IsMatch(equation, @"²√\(?([0-9\.\+\-\*/\s\(\)]+)\)?"))
            {
                equation = Regex.Replace(equation, @"²√\(?([0-9\.\+\-\*/\s\(\)]+)\)?", match =>
                {
                    string innerExpr = match.Groups[1].Value;
                    try
                    {
                        var innerValue = new DataTable().Compute(innerExpr, null);
                        double val = Convert.ToDouble(innerValue);
                        return Math.Sqrt(val).ToString();
                    }
                    catch
                    {
                        return "0";
                    }
                });
            }

            while (Regex.IsMatch(equation, @"(\d+(\.\d+)?)\s*([+\-*/])\s*(\d+(\.\d+)?)%"))
            {
                equation = Regex.Replace(equation, @"(\d+(\.\d+)?)\s*([+\-*/])\s*(\d+(\.\d+)?)%", match =>
                {
                    double baseNum = double.Parse(match.Groups[1].Value);
                    string op = match.Groups[3].Value;
                    double percent = double.Parse(match.Groups[4].Value) / 100.0;

                    switch (op)
                    {
                        case "+": return $"{baseNum} + ({baseNum}*{percent})";
                        case "-": return $"{baseNum} - ({baseNum}*{percent})";
                        case "*": return $"{baseNum}*{percent}";
                        case "/": return $"{baseNum}/({percent})";
                        default: return match.Value;
                    }
                });
            }

            equation = Regex.Replace(equation, @"(?<![\w\.])(\d+)(?![\w\.])", "$1.0");

            try
            {
                var result = new DataTable().Compute(equation, null);
                double value = Convert.ToDouble(result);
                OutputTextBox.Text = Math.Round(value, 5).ToString("0.#####");
            }
            catch (Exception error)
            {
                OutputTextBox.Text = $"Math Error: {error.Message}";
            }
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (OutputTextBox.Text.EndsWith("²") || OutputTextBox.Text.EndsWith("%")) return;
            else if (OutputTextBox.Text == "0" && button.Text != ".") OutputTextBox.Text = $" {button.Text}";
            else if (OutputTextBox.Text.EndsWith(" ") && button.Text == ".") OutputTextBox.Text += "0.";
            else OutputTextBox.Text += button.Text;
        }

        private void OperationButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (OutputTextBox.Text.EndsWith(" ") || OutputTextBox.Text.EndsWith(".")) return;
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
            if (OutputTextBox.Text == "0" || OutputTextBox.Text.EndsWith(" ") || OutputTextBox.Text.EndsWith("-") || OutputTextBox.Text.EndsWith("²") || OutputTextBox.Text.EndsWith("%") || OutputTextBox.Text.EndsWith(".")) return;
            OutputTextBox.Text += "²";
        }

        private void OneFractionOverButton_Clicked(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0" || OutputTextBox.Text.EndsWith(".") || OutputTextBox.Text.EndsWith(" ") || OutputTextBox.Text.EndsWith("-")) return;
            
            EqualsButton_Clicked(sender, e);

            string equation = $"1/({OutputTextBox.Text})";
            var result = new DataTable().Compute(equation, null);
            double value = Convert.ToDouble(result);

            OutputTextBox.Text = Math.Round(value, 5).ToString();
        }

        private void PercentButton_Clicked(Object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0" || OutputTextBox.Text.EndsWith(" ") || OutputTextBox.Text.EndsWith("-") || OutputTextBox.Text.EndsWith("²") || OutputTextBox.Text.EndsWith("%") || OutputTextBox.Text.EndsWith(".")) return;

            OutputTextBox.Text += "%";
        }

        private void SquareRootButton_Clicked(Object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0" || OutputTextBox.Text.EndsWith("-") || OutputTextBox.Text.EndsWith("²") || OutputTextBox.Text.EndsWith("%") || OutputTextBox.Text.EndsWith(".")) return;

            var match = Regex.Match(OutputTextBox.Text, @"(\d+(\.\d+)?|\([^\(\)]+\))$");

            if (match.Success && !OutputTextBox.Text.EndsWith(" "))
            {
                int index = match.Index;
                OutputTextBox.Text = OutputTextBox.Text.Insert(index, "²√");
            }
            else
            {
                OutputTextBox.Text += "²√";
            }
        }
    }
}
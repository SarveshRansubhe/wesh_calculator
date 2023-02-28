using System.Runtime.CompilerServices;

namespace wesh_calculator
{
    public partial class calculator : Form
    {

        private decimal leftValue = 0.0m;
        private decimal rightValue = 0.0m;
        private decimal result = 0.0m;
        private string operatorValue = "";

        public calculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "0";
            }
            else
            {
                ResultBox.Text += "0";
            }
        }
        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "1";
            }
            else
            {
                ResultBox.Text += "1";
            }
        }
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "2";
            }
            else
            {
                ResultBox.Text += "2";
            }
        }
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "3";
            }
            else
            {
                ResultBox.Text += "3";
            }
        }
        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "4";
            }
            else
            {
                ResultBox.Text += "4";
            }
        }
        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "5";
            }
            else
            {
                ResultBox.Text += "5";
            }
        }
        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "6";
            }
            else
            {
                ResultBox.Text += "6";
            }
        }
        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "7";
            }
            else
            {
                ResultBox.Text += "7";
            }
        }
        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "8";
            }
            else
            {
                ResultBox.Text += "8";
            }
        }
        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "9";
            }
            else
            {
                ResultBox.Text += "9";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!ResultBox.Text.Contains("."))
            {
                ResultBox.Text += ".";
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            leftValue = decimal.Parse(ResultBox.Text);
            ResultBox.Clear();
            operatorValue = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            leftValue = decimal.Parse(ResultBox.Text);
            ResultBox.Clear();
            operatorValue = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            leftValue = decimal.Parse(ResultBox.Text);
            ResultBox.Clear();
            operatorValue = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            leftValue = decimal.Parse(ResultBox.Text);
            ResultBox.Clear();
            operatorValue = "*";
        }

        private void PercentageBtn_Click(object sender, EventArgs e)
        {
            leftValue = decimal.Parse(ResultBox.Text);
            ResultBox.Clear();
            operatorValue = "%";
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Contains("-"))
            {
                ResultBox.Text = ResultBox.Text.Trim('-');
            }
            else
            {
                ResultBox.Text = "-" + ResultBox.Text;
            }
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operatorValue)
            {
                case "+":
                    rightValue = decimal.Parse(ResultBox.Text);
                    result = leftValue + rightValue;
                    ResultBox.Text = result.ToString();
                    break;

                case "-":
                    rightValue = decimal.Parse(ResultBox.Text);
                    result = leftValue - rightValue;
                    ResultBox.Text = result.ToString();
                    break;

                case "*":
                    rightValue = decimal.Parse(ResultBox.Text);
                    result = leftValue * rightValue;
                    ResultBox.Text = result.ToString();
                    break;

                case "/":
                    rightValue = decimal.Parse(ResultBox.Text);
                    result = leftValue / rightValue;
                    ResultBox.Text = result.ToString();
                    break;
                case "%":
                    rightValue = decimal.Parse(ResultBox.Text);
                    result = leftValue % rightValue;
                    ResultBox.Text = result.ToString();
                    break;
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            operatorValue = "";
            leftValue = 0.0m;
            rightValue = 0.0m;

        }
    }
}
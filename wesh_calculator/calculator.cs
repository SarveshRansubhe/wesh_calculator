namespace wesh_calculator
{
    public partial class calculator : Form
    {
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

    }
}
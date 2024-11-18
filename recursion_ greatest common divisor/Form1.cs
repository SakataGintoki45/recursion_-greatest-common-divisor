namespace recursion__greatest_common_divisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b); 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber1.Text, out int number1) &&
              int.TryParse(txtNumber2.Text, out int number2))
            {
                if (number1 < 0 || number2 < 0)
                {
                    MessageBox.Show("Please enter positive numbers.");
                    return;
                }

                int result = GCD(number1, number2);
                lblResult.Text = $"The GCD of {number1} and {number2} is: {result}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}

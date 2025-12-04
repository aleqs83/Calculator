namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        string arithmatic = "";
        int num1 = 0;
        int num2 = 0;
        int total = 0;
        public MainPage()
        {
            InitializeComponent();
            LblDisplay.Text = "";
        }

        private void ClearAllButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LblDisplay.Text += btn;
            if (btn.Text == "AC")
            {
                LblDisplay.Text = "";
                num1 = 0;
                num2 = 0;

            }
        }
        private void Button_eq_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (arithmatic == "+")
            {
              total = num1 + num2;
            }
            else if (arithmatic == "-")
            {
                total = num1 - num2;
            }
            else if (arithmatic == "*")
            {
                total = num1 * num2;
            }
            else if (arithmatic == "/")
            {
                total = num1 / num2;
            }
            LblDisplay.Text = "= " + total.ToString();
                LblDisplay.Text = "";
                num1 = 0;
                num2 = 0;
                arithmatic = "";
                total = 0;         
        }
        private void ArithmeticButton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LblDisplay.Text += btn.Text;
            arithmatic += btn.Text;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LblDisplay.Text += btn.Text;
            if(arithmatic == "")
            {
                num1 = num1 * 10 + int.Parse(btn.Text);
            }
            else
            {
                num2 = num2 * 10 + int.Parse(btn.Text);
            }

        }
    }

}

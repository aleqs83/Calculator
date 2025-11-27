namespace Calculator
{
    public partial class MainPage : ContentPage
    {

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

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LblDisplay.Text += btn.Text;

        }
    }

}

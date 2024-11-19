namespace ZmianaStopni
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var wartosc = Convert.ToDouble(stopnie.Text);

            var typ = rodzaj.SelectedIndex;
            if (typ == 0) //Celcjusze na Faranhaity
            {
                var convert = (wartosc * 1.8) + 32;
                convert = Math.Round(convert, 2);
                wynik.Text = convert.ToString();
            }
            if (typ == 1) //Farankhaity na Celcjusze
            {
                var convert = (wartosc - 32) /1.8;
                convert = Math.Round(convert, 2);
                wynik.Text = convert.ToString();
            }

            
        }
    }

}

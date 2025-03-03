namespace UI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void IniciarSesion(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                Iniciar.Text = $"Clicked {count} time";
            else
                Iniciar.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(Iniciar.Text);

            await Shell.Current.GoToAsync("///Menu");
        }
    }

}

namespace UI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Iniciar.IsEnabled = false;
        }

        private async void IniciarSesion(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Menu");
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            // Verificar si los campos no están vacíos ni contienen solo espacios
            bool isNombreFilled = !string.IsNullOrWhiteSpace(NombreEntry.Text);
            bool isContrasenaFilled = !string.IsNullOrWhiteSpace(ContrasenaEntry.Text);

            // Habilita el botón solo si ambos campos tienen contenido válido
            Iniciar.IsEnabled = isNombreFilled && isContrasenaFilled;
        }


    }
}

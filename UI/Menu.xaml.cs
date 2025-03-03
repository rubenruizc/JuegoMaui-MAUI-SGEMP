namespace UI;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void EmpezarJuego(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("///PaginaJuego");
    }
}
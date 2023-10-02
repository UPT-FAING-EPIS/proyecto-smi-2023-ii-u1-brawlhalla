namespace equipo_app.Views;

public partial class ListadoEquipos : ContentPage
{
	public ListadoEquipos()
	{
		InitializeComponent();
		BindingContext = App.Current.Services.GetService<EquiposViewModels>();
	}

    
}
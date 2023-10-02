namespace equipo_app.Views;

public partial class equipo : ContentPage
{
	public equipo()
	{
		BindingContext = App.Current.Services.GetService<EquiposViewModels>();
		InitializeComponent();

	}
}

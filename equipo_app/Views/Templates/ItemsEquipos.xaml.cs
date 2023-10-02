namespace equipo_app.Views.Templates;

public partial class ItemsEquipos : ContentView
{
	private readonly EquiposViewModels viewmodel;
	public ItemsEquipos()
	{
		try
		{

		

		viewmodel = App.Current.Services.GetService<EquiposViewModels>();
            InitializeComponent();
          //  BindingContext = viewmodel;

        }
        catch (Exception ex)
        {

            throw ex;
        }
        
	}
}
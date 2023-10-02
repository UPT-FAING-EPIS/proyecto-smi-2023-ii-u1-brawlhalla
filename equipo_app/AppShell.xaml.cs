using equipo_app.Views;

namespace equipo_app;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(equipo), typeof(equipo));
        Routing.RegisterRoute(nameof(ListadoEquipos), typeof(ListadoEquipos));
    }
}

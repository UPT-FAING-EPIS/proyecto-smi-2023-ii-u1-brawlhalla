using Stage_App.Views;

namespace Stage_App;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(organizador), typeof(organizador));
        Routing.RegisterRoute(nameof(ListadoOrganizadores), typeof(ListadoOrganizadores));
    }
}

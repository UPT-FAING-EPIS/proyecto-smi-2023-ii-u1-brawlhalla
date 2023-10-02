using Stage_App.Services;

namespace Stage_App;

public partial class App : Application
{
    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }
    public App()
    {
        var services = new ServiceCollection();

        Services = ConfigureServices(services);

        InitializeComponent();

        MainPage = new AppShell();
    }

    private static IServiceProvider ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<IOrganizadores, OrganizadoresServices>();

        //ViewModels
        services.AddTransient<OrganizadoresViewModels>();
        services.AddTransient<organizadorViewModels>();

        //Views
        services.AddSingleton<ListadoOrganizadores>();
        services.AddSingleton<organizador>();

        //Services
        services.AddTransient<IOrganizadores, OrganizadoresServices>();
        services.AddTransient<IDialogService, DialogService>();


        return services.BuildServiceProvider();
    }
}

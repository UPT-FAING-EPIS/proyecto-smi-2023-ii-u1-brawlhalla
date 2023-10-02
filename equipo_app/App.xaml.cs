using equipo_app.Services;

namespace equipo_app;

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

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private static IServiceProvider ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<IEquipos, EquiposServices>();

        //ViewModels
        services.AddTransient<EquiposViewModels>();
        services.AddTransient<EquipoViewModels>();

        //Views
        services.AddSingleton<ListadoEquipos>();
        services.AddSingleton<equipo>();

        //Services
        services.AddTransient<IEquipos, EquiposServices>();
        services.AddTransient<IDialogService, DialogService>();


        return services.BuildServiceProvider();
    }
}

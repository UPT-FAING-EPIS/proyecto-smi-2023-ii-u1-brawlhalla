using equipo_app.ViewModels;
using equipo_app.Views;
using Microsoft.Extensions.DependencyInjection;
using equipo_app.Interfaces;
using equipo_app.Services;

namespace equipo_app;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//SQL Lite
		string dbPath = FileAccessHelper.GetPathFile("Equipos.db3");
	//	builder.Services.AddSingleton<EquiposModels>(s => ActivatorUtilities.CreateInstance<EquiposModels>(s, dbPath));

     

		return builder.Build();
	}

}

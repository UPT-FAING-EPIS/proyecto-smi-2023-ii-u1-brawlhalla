using Stage_App.ViewModels;
using Stage_App.Views;
using Microsoft.Extensions.DependencyInjection;
using Stage_App.Interfaces;
using Stage_App.Services;

namespace Stage_App;

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
		string dbPath = FileAccessHelper.GetPathFile("Organizadores.db3");
	//	builder.Services.AddSingleton<OrganizadoresModels>(s => ActivatorUtilities.CreateInstance<OrganizadoresModels>(s, dbPath));

     

		return builder.Build();
	}

}

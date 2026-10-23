using Microsoft.Extensions.Logging;
using OndeEstouApp.ViewModels;

namespace OndeEstouApp
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //Registrar views
            builder.Services.AddTransient<LocalPage>();

            //Registrar viewmodels
            builder.Services.AddTransient<LocalViewModel>();

            //Registrar services
            builder.Services.AddSingleton<IGeoService, GeoService>();

            return builder.Build();
        }
    }
}

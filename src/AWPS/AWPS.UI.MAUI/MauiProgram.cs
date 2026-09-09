using AWPS.UI.MAUI.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace AWPS.UI.MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        });
        builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite($"Data Source={Path.Combine(FileSystem.AppDataDirectory, "awps.db")}");
        });
        return builder.Build();
    }
}
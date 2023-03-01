using CommunityToolkit.Maui;
using Java.Lang;
using MauiApp3.ViewModels;
using MauiApp3.Views;
using Microsoft.Extensions.Logging;

namespace MauiApp3;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        RegisterViews(builder);
        return builder.Build();
    }
   
    public static void RegisterViews(MauiAppBuilder builder)
    {
        builder.Services.AddTransient<Class1>();
        builder.Services.AddTransient<NewPage1>();
        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));

        builder.Services.AddTransient<Class2>();
        builder.Services.AddTransient<NewPage2>();
        Routing.RegisterRoute(nameof(NewPage2), typeof(NewPage2));

        builder.Services.AddTransient<Class3>();
        builder.Services.AddTransient<NewPage3>();
        Routing.RegisterRoute(nameof(NewPage3), typeof(NewPage3));

        builder.Services.AddTransient<Class4>();
        builder.Services.AddTransient<NewPage4>();
        Routing.RegisterRoute(nameof(NewPage4), typeof(NewPage4));

        builder.Services.AddTransient<Class5>();
        builder.Services.AddTransient<NewPage5>();
        Routing.RegisterRoute(nameof(NewPage5), typeof(NewPage5));

        builder.Services.AddTransient<Class6>();
        builder.Services.AddTransient<NewPage6>();
        Routing.RegisterRoute(nameof(NewPage6), typeof(NewPage6));

        builder.Services.AddTransient<Class7>();
        builder.Services.AddTransient<NewPage7>();
        Routing.RegisterRoute(nameof(NewPage7), typeof(NewPage7));

        builder.Services.AddTransient<Class8>();
        builder.Services.AddTransient<NewPage8>();
        Routing.RegisterRoute(nameof(NewPage8), typeof(NewPage8));

        builder.Services.AddTransient<Class9>();
        builder.Services.AddTransient<NewPage9>();
        Routing.RegisterRoute(nameof(NewPage9), typeof(NewPage9));

        builder.Services.AddTransient<Class10>();
        builder.Services.AddTransient<NewPage10>();
        Routing.RegisterRoute(nameof(NewPage10), typeof(NewPage10));

        builder.Services.AddTransient<Class11>();
        builder.Services.AddTransient<NewPage11>();
        Routing.RegisterRoute(nameof(NewPage11), typeof(NewPage11));

        builder.Services.AddTransient<Class12>();
        builder.Services.AddTransient<NewPage12>();
        Routing.RegisterRoute(nameof(NewPage12), typeof(NewPage12));

        builder.Services.AddTransient<Class13>();
        builder.Services.AddTransient<NewPage13>();
        Routing.RegisterRoute(nameof(NewPage13), typeof(NewPage13));

        builder.Services.AddTransient<Class14>();
        builder.Services.AddTransient<NewPage14>();
        Routing.RegisterRoute(nameof(NewPage14), typeof(NewPage14));

        builder.Services.AddTransient<Class15>();
        builder.Services.AddTransient<NewPage15>();
        Routing.RegisterRoute(nameof(NewPage15), typeof(NewPage15));

        builder.Services.AddTransient<Class16>();
        builder.Services.AddTransient<NewPage16>();
        Routing.RegisterRoute(nameof(NewPage16), typeof(NewPage16));

        builder.Services.AddTransient<SettAvm>();
        builder.Services.AddTransient<SettA>();
        Routing.RegisterRoute(nameof(SettA), typeof(SettA));

        builder.Services.AddTransient<SettBvm>();
        builder.Services.AddTransient<SettB>();
        Routing.RegisterRoute(nameof(SettB), typeof(SettB));

        builder.Services.AddTransient<TabAvm>();
        builder.Services.AddTransient<TabA>();
        Routing.RegisterRoute(nameof(TabA), typeof(TabA));

        builder.Services.AddTransient<TabBvm>();
        builder.Services.AddTransient<TabB>();
        Routing.RegisterRoute(nameof(TabB), typeof(TabB));

        builder.Services.AddTransient<TabCvm>();
        builder.Services.AddTransient<TabC>();
        Routing.RegisterRoute(nameof(TabC), typeof(TabC));

        builder.Services.AddTransient<TabDvm>();
        builder.Services.AddTransient<TabD>();
        Routing.RegisterRoute(nameof(TabD), typeof(TabD));

        builder.Services.AddTransient<TabEvm>();
        builder.Services.AddTransient<TabE>();
        Routing.RegisterRoute(nameof(TabE), typeof(TabE));

        builder.Services.AddTransient<TabFvm>();
        builder.Services.AddTransient<TabF>();
        Routing.RegisterRoute(nameof(TabF), typeof(TabF));

        builder.Services.AddTransient<TabGvm>();
        builder.Services.AddTransient<TabG>();
        Routing.RegisterRoute(nameof(TabG), typeof(TabG));

        builder.Services.AddTransient<TabHvm>();
        builder.Services.AddTransient<TabH>();
        Routing.RegisterRoute(nameof(TabH), typeof(TabH));

        //builder.Services.AddTransient<AppShell>();    
    }
}

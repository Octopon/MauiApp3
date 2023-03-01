using MauiApp3.Views;
using System.Collections.Specialized;
using static Android.App.DownloadManager;

namespace MauiApp3;

public partial class AppShell : Shell {
    public AppShell() {
        InitializeComponent();
        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
    }


    public static void SwitchToMainShellItem() {
        NavigationUtil.NavigateShell(nameof(MainShellItem));
    }

    public static void SwitchToLoginShellItem() {
        NavigationUtil.NavigateShell(nameof(TabHShellItem));
    }

    public static void SwitchToResetShellItem() {
        NavigationUtil.NavigateShell(nameof(ResetShellItem));
    }

    private void MenuItem_Clicked(object sender, EventArgs e) {
        //Shell.Current.GoToAsync(nameof(NewPage1));

        NavigationUtil.Navigate<NewPage1>();
        //NavigationUtil.NavigateShell(nameof(ResetShellItem));
    }
}

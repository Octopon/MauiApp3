using CommunityToolkit.Mvvm.Input;
using MauiApp3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels
{
    public partial class Class16: BaseViewModel
    {
        [RelayCommand]
        private void NextButtonPressed()
        {
           // NavigationUtil.Navigate<NewPage1>();
            AppShell.SwitchToLoginShellItem();
        }

    }
}

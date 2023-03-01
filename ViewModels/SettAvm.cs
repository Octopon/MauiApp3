using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp3.Views;

namespace MauiApp3.ViewModels
{
    public partial class SettAvm : BaseViewModel
    {
        [RelayCommand]
        private void NextButtonPressed()
        {
            NavigationUtil.Navigate<NewPage10>();
        }

    }
}

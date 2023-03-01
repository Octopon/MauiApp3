using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class SettA : ContentPage
{
    public ContentPageUtil<SettAvm> PageUtil { get; set; }

    public SettA(SettAvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<SettAvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
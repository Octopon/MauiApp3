using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class SettB : ContentPage
{
    public ContentPageUtil<SettBvm> PageUtil { get; set; }

    public SettB(SettBvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<SettBvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
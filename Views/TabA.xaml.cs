using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabA : ContentPage
{
    public ContentPageUtil<TabAvm> PageUtil { get; set; }

    public TabA(TabAvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabAvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
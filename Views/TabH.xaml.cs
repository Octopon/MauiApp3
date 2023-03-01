using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabH : ContentPage
{
    public ContentPageUtil<TabHvm> PageUtil { get; set; }

    public TabH(TabHvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabHvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
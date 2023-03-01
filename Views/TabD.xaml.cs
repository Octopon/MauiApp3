using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabD : ContentPage
{
    public ContentPageUtil<TabDvm> PageUtil { get; set; }

    public TabD(TabDvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabDvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
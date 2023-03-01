using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabE : ContentPage
{
    public ContentPageUtil<TabEvm> PageUtil { get; set; }

    public TabE(TabEvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabEvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
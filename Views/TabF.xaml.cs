using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabF : ContentPage
{
    public ContentPageUtil<TabFvm> PageUtil { get; set; }

    public TabF(TabFvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabFvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
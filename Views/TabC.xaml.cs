using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabC : ContentPage
{
    public ContentPageUtil<TabCvm> PageUtil { get; set; }

    public TabC(TabCvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabCvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
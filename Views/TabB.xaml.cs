using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class TabB : ContentPage
{
    public ContentPageUtil<TabBvm> PageUtil { get; set; }

    public TabB(TabBvm vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<TabBvm>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
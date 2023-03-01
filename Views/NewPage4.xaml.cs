using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage4 : ContentPage
{
    public ContentPageUtil<Class4> PageUtil { get; set; }

    public NewPage4(Class4 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class4>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
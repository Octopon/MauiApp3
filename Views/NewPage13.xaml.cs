using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage13 : ContentPage
{
    public ContentPageUtil<Class13> PageUtil { get; set; }

    public NewPage13(Class13 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class13>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
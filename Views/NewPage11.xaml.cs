using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage11 : ContentPage
{
    public ContentPageUtil<Class11> PageUtil { get; set; }

    public NewPage11(Class11 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class11>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
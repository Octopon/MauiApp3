using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage1 : ContentPage
{
    public ContentPageUtil<Class1> PageUtil { get; set; }

    public NewPage1(Class1 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class1>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
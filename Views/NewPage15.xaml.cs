using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage15 : ContentPage
{
    public ContentPageUtil<Class15> PageUtil { get; set; }

    public NewPage15(Class15 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class15>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
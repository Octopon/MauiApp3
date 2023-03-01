using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage10 : ContentPage
{
    public ContentPageUtil<Class10> PageUtil { get; set; }

    public NewPage10(Class10 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class10>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
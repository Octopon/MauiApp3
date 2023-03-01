using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage8 : ContentPage
{
    public ContentPageUtil<Class8> PageUtil { get; set; }

    public NewPage8(Class8 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class8>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
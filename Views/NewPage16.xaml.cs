using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage16 : ContentPage
{
    public ContentPageUtil<Class16> PageUtil { get; set; }

    public NewPage16(Class16 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class16>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
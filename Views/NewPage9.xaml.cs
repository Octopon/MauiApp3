using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage9 : ContentPage
{
    public ContentPageUtil<Class9> PageUtil { get; set; }

    public NewPage9(Class9 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class9>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
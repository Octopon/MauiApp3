using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage5 : ContentPage
{
    public ContentPageUtil<Class5> PageUtil { get; set; }

    public NewPage5(Class5 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class5>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
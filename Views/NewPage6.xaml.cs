using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage6 : ContentPage
{
    public ContentPageUtil<Class6> PageUtil { get; set; }

    public NewPage6(Class6 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class6>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
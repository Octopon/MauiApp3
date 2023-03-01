using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage14 : ContentPage
{
    public ContentPageUtil<Class14> PageUtil { get; set; }

    public NewPage14(Class14 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class14>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
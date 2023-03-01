using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage12 : ContentPage
{
    public ContentPageUtil<Class12> PageUtil { get; set; }

    public NewPage12(Class12 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class12>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
using MauiApp3.ViewModels;

namespace MauiApp3.Views;

public partial class NewPage7 : ContentPage
{
    public ContentPageUtil<Class7> PageUtil { get; set; }

    public NewPage7(Class7 vm)
    {
        InitializeComponent();

        PageUtil = new ContentPageUtil<Class7>(this, vm);
        BindingContext = PageUtil.PageBindingContext;
    }

}
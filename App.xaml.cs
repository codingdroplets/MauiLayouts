using MauiLayouts.Pages;

namespace MauiLayouts;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var navigationPage = new NavigationPage(new StackLayoutDemo());
        MainPage = navigationPage;
    }
}

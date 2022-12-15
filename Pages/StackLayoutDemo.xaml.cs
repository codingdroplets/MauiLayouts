namespace MauiLayouts.Pages;

public partial class StackLayoutDemo : ContentPage
{
	public StackLayoutDemo()
	{
		InitializeComponent();
	}

    private void verticalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VerticalStackLayoutDemo());
    }

    private void horizontalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalStackLayoutDemo());
    }

    private void gridButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridDemo());
    }

    private void absoluteLayoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutDemo());
    }

    private void flexLayoutButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayoutDemo());
    }
}
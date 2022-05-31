namespace MauiIssueFlexBoxIsVisible;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		image.IsVisible = !image.IsVisible;
	}
}


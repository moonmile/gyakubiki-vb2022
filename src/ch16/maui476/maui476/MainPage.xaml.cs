using Microsoft.Maui.Platform;

namespace maui476;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MauiLib.MainViewModel();
	}
}


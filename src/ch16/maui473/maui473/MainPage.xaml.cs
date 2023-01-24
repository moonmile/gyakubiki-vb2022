namespace maui473;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MauiLib.MainViewModel();
	}
}


namespace maui471;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MauiLib.MainViewModel();
	}
}


namespace maui468;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		var vm = new MauiLib.MainViewModel();
		vm.DisplayAlert += (title,message,btn) => DisplayAlert(title,message,btn);
		this.BindingContext = vm;
	}
}


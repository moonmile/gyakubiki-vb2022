using mauilib;

namespace mauivb;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		_vm = new ViewModel();
		this.BindingContext = _vm;
	}
	ViewModel _vm;
	private void OnInputClicked(object sender, EventArgs e)
	{
		_vm.Result = $"{_vm.Name} ({_vm.Age}) in {_vm.Address}";
	}
}


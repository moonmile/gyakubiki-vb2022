﻿namespace maui456;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MauiLib.MainViewModel();
	}
}


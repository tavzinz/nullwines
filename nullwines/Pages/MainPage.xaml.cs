using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using nullwines.ViewModels;
using Xamarin.Forms;

namespace nullwines.Pages
{
    public partial class MainPage : ContentPage
    {
        WinesViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            vm = new WinesViewModel();
            BindingContext = vm;
        }

		protected override void OnAppearing()
		{
            base.OnAppearing();
            vm.LoadItems();
                

		}


	}
}

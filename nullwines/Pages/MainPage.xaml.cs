using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using nullwines.ViewModels;
using Xamarin.Forms;

namespace nullwines.Pages
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new WineList();

        }


	}
}

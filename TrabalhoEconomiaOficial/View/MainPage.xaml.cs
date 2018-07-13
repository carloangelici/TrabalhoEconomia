using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

        }
    }
}

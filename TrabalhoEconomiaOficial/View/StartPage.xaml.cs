using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            BindingContext = new StartViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}

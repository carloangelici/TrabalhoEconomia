using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class MainMicroPage : ContentPage
    {
        public MainMicroPage()
        {
            InitializeComponent();
            BindingContext = new MainMicroViewModel();

        }
    }
}

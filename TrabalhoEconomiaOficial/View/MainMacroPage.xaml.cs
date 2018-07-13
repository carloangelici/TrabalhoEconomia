using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class MainMacroPage : ContentPage
    {
        public MainMacroPage()
        {
            InitializeComponent();
            BindingContext = new MainMacroViewModel();
        }
    }
}

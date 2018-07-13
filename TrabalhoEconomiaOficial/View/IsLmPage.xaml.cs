using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class IsLmPage : ContentPage
    {
        public IsLmPage()
        {
            InitializeComponent();
            BindingContext = new IsLmViewModel();
        }
    }
}

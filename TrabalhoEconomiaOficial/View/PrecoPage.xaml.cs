using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class PrecoPage : ContentPage
    {
        public PrecoPage()
        {
            InitializeComponent();
            BindingContext = new PrecoViewModel();
        }
    }
}

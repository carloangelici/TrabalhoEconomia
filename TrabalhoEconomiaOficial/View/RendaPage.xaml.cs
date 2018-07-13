using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class RendaPage : ContentPage
    {
        public RendaPage()
        {
            InitializeComponent();
            BindingContext = new RendaViewModel();
        }
    }
}

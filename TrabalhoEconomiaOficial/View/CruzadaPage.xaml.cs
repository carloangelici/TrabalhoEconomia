using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class CruzadaPage : ContentPage
    {
        public CruzadaPage()
        {
            InitializeComponent();
            BindingContext = new CruzadaViewModel();
        }
    }
}

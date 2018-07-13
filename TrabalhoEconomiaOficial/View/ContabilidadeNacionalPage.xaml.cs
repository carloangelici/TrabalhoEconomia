using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class ContabilidadeNacionalPage : ContentPage
    {
        public ContabilidadeNacionalPage()
        {
            InitializeComponent();
            BindingContext = new ContabilidadeNacionalViewModel();

        }
    }
}

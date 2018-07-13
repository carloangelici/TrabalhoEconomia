using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class TeoriaCustosPage : ContentPage
    {
        public TeoriaCustosPage()
        {
            InitializeComponent();
            BindingContext = new TeoriaCustosViewModel();
        }
    }
}

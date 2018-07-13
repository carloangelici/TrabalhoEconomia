using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class InflacaoPage : ContentPage
    {
        public InflacaoPage()
        {
            InitializeComponent();
            BindingContext = new InflacaoViewModel();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using TrabalhoEconomiaOficial.ViewModel;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public partial class ElasticidadePage : ContentPage
    {
        public ElasticidadePage()
        {
            InitializeComponent();
            BindingContext = new ElasticidadeViewModel();
        }
    }
}

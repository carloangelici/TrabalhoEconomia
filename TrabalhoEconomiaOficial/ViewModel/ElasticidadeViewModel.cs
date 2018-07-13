using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class ElasticidadeViewModel : ContentPage
    {
        public ElasticidadeViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.View
{
    public class ContabilidadeNacionalPage : ContentPage
    {
        public ContabilidadeNacionalPage()
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


using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class IsLmViewModel : ContentPage
    {
        public IsLmViewModel()
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


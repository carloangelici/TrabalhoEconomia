using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class MainMacroViewModel : ContentPage
    {
        public MainMacroViewModel()
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


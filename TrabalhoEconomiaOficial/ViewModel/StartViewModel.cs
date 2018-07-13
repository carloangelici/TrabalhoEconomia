using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class StartViewModel : ContentPage
    {
        public StartViewModel()
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


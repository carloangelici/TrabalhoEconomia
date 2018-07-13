using System;
using TrabalhoEconomiaOficial.View;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class StartViewModel : ContentPage
    {
        public Command OnButtonClicked { get; }
        public StartViewModel()
        {
            OnButtonClicked = new Command(ExecuteButtonClicked);
        }

        public void ExecuteButtonClicked()
        {
            Application.Current.MainPage.Navigation?.PushAsync(new MainPage());
        }
    }
}


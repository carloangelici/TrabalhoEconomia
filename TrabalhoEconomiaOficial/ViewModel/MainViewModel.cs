using System;
using TrabalhoEconomiaOficial.View;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class MainViewModel : ContentPage
    {
        public Command OnMicroClicked { get; }
        public Command OnMacroClicked { get; }
        public MainViewModel()
        {
            OnMicroClicked = new Command(ExecuteMicroClicked);
            OnMacroClicked = new Command(ExecuteMacroClicked);
        }

        public void ExecuteMicroClicked()
        {
            Application.Current.MainPage.Navigation?.PushAsync(new MainMicroPage());
        }

        public void ExecuteMacroClicked()
        {
            Application.Current.MainPage.Navigation?.PushAsync(new MainMacroPage());
        }
    }
}


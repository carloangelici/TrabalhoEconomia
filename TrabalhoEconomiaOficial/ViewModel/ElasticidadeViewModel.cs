using System;
using TrabalhoEconomiaOficial.View;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class ElasticidadeViewModel : ContentPage
    {
        public Command RendaClicked { get; }
        public Command PrecoClicked { get; }
        public Command CruzadaClicked { get; }
        public ElasticidadeViewModel()
        {
            RendaClicked = new Command(ExecuteRendaClicked);
            PrecoClicked = new Command(ExecutePrecoClicked);
            CruzadaClicked = new Command(ExecuteCruzadaClicked);
        }

        public void ExecuteRendaClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new RendaPage());
        }

        public void ExecutePrecoClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new PrecoPage());
        }

        public void ExecuteCruzadaClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new CruzadaPage());
        }
    }
}


using System;
using TrabalhoEconomiaOficial.View;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class MainMicroViewModel : ContentPage
    {
        public Command OnOfertaDemandaClicked { get; }
        public Command OnTeoriaCustosClicked { get; }
        public Command OnElasticidadeClicked { get; }
        public MainMicroViewModel()
        {
            OnOfertaDemandaClicked = new Command(ExecuteOfertaDemandaClicked);
            OnTeoriaCustosClicked = new Command(ExecuteTeoriaCustosClicked);
            OnElasticidadeClicked = new Command(ExecuteElasticidadeClicked);
        }

        public void ExecuteOfertaDemandaClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new OfertaDemandaPage());
        }
        public void ExecuteTeoriaCustosClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new TeoriaCustosPage());
        }
        public void ExecuteElasticidadeClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ElasticidadePage());
        }
    }
}


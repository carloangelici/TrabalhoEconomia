using System;
using TrabalhoEconomiaOficial.View;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class MainMacroViewModel : ContentPage
    {
        public Command OnContabilidadeNacionalClicked { get; }
        public Command OnInflacaoClicked { get; }
        public Command OnIsLmClicked { get; }
        public MainMacroViewModel()
        {
            OnContabilidadeNacionalClicked = new Command(ExecuteContabilidadeNacionalClicked);
            OnInflacaoClicked = new Command(ExecuteInflacaoClicked);
            OnIsLmClicked = new Command(ExecuteIsLmClicked);
        }

        public void ExecuteContabilidadeNacionalClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ContabilidadeNacionalPage());
        }
        public void ExecuteInflacaoClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new InflacaoPage());
        }
        public void ExecuteIsLmClicked()
        {
            Application.Current.MainPage.Navigation.PushAsync(new IsLmPage());
        }
    }
}


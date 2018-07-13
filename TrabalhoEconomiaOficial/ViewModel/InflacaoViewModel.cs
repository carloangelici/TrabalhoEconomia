using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class InflacaoViewModel : BaseViewModel
    {
        public string Ano { get; set; }
        public string _Inflacao;

        public string Inflacao
        {
            get { return _Inflacao; }
            set { SetPropertyChanged(ref _Inflacao, value); }
        }

        public Command OnMostrarInflacaoClicked { get; }

        public InflacaoViewModel()
        {
            OnMostrarInflacaoClicked = new Command(ExecuteMostrarInflacaoClicked);
        }

        public void ExecuteMostrarInflacaoClicked()
        {
            if(Ano == "2007")
            {
                Inflacao = "4,45%";
            }
            if(Ano == "2008")
            {
                Inflacao = "5,90%";
            }  
            if(Ano == "2009")
            {
                Inflacao = "4,31%";
            }  
            if(Ano == "2010")
            {
                Inflacao = "5,90%";
            }  
            if(Ano == "2011")
            {
                Inflacao = "6,50%";
            }  
            if(Ano == "2012")
            {
                Inflacao = "5,83%";
            }  
            if(Ano == "2013")
            {
                Inflacao = "5,91%";
            }  
            if(Ano == "2014")
            {
                Inflacao = "6,41%";
            }  
            if(Ano == "2015")
            {
                Inflacao = "10,67%";
            }  
            if(Ano == "2016")
            {
                Inflacao = "6,29%";
            }  
            if(Ano == "2017")
            {
                Inflacao = "2,21%";
            }
            //else
            //{
            //    Application.Current.MainPage.DisplayAlert("Ano inválido", "Digite um ano válido(2007 a 2017)", "Cancel");
            //}
        }
    }
}


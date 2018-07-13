using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class OfertaDemandaViewModel : BaseViewModel
    {
        public Command AumentarClicked { get; }
        public Command DiminuirClicked { get; }
        public Command AumentarDemandaClicked { get; }
        public Command DiminuirDemandaClicked { get; }

        private bool _OfertaAumentaVisible;
        private bool _OfertaDiminuiVisible;

        private bool _DemandaAumentaVisible;
        private bool _DemandaDiminuiVisible;

        public bool OfertaAumentaVisible
        {
            get { return _OfertaAumentaVisible; }
            set { SetPropertyChanged(ref _OfertaAumentaVisible, value); }
        }

        public bool OfertaDiminuiVisible
        {
            get { return _OfertaDiminuiVisible; }
            set { SetPropertyChanged(ref _OfertaDiminuiVisible, value); }
        }

        public bool DemandaAumentaVisible
        {
            get { return _DemandaAumentaVisible; }
            set { SetPropertyChanged(ref _DemandaAumentaVisible, value); }
        }

        public bool DemandaDiminuiVisible
        {
            get { return _DemandaDiminuiVisible; }
            set { SetPropertyChanged(ref _DemandaDiminuiVisible, value); }
        }

        public OfertaDemandaViewModel()
        {
            AumentarClicked = new Command(ExecuteAumentarClicked);
            DiminuirClicked = new Command(ExecuteDiminuirClicked);
            AumentarDemandaClicked = new Command(ExecuteAumentarDemandaClicked);
            DiminuirDemandaClicked = new Command(ExecuteDiminuirDemandaClicked);
            OfertaDiminuiVisible = false;
            OfertaAumentaVisible = false;
            DemandaDiminuiVisible = false;
            DemandaAumentaVisible = false;
        }

        public void ExecuteAumentarClicked()
        {
            OfertaAumentaVisible = true;
            OfertaDiminuiVisible = false;
        }

        public void ExecuteDiminuirClicked()
        {
            OfertaAumentaVisible = false;
            OfertaDiminuiVisible = true;
        }

        public void ExecuteAumentarDemandaClicked()
        {
            DemandaAumentaVisible = true;
            DemandaDiminuiVisible = false;
        }

        public void ExecuteDiminuirDemandaClicked()
        {
            DemandaAumentaVisible = false;
            DemandaDiminuiVisible = true;
        }
    }
}


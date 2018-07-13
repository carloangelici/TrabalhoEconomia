using System;

using Xamarin.Forms;

namespace TrabalhoEconomiaOficial.ViewModel
{
    public class IsLmViewModel : BaseViewModel
    {
        public Command ExpansaoFiscalClicked { get; }
        public Command RetracaoFiscalClicked { get; }
        public Command ExpansaoMonetariaClicked { get; }
        public Command RetracaoMonetariaClicked { get; }

        private bool _ExpansaoFiscalVisible;
        private bool _RetracaoFiscalVisible;
        private bool _OriginalVisible;
        private bool _ExpansaoMonetariaVisible;
        private bool _RetracaoMonetariaVisible;

        public bool OriginalVisible
        {
            get { return _OriginalVisible; }
            set { SetPropertyChanged(ref _OriginalVisible, value); }
        }

        public bool ExpansaoFiscalVisible
        {
            get { return _ExpansaoFiscalVisible; }
            set { SetPropertyChanged(ref _ExpansaoFiscalVisible, value); }
        }

        public bool RetracaoFiscalVisible
        {
            get { return _RetracaoFiscalVisible; }
            set { SetPropertyChanged(ref _RetracaoFiscalVisible, value); }
        }

        public bool ExpansaoMonetariaVisible
        {
            get { return _ExpansaoMonetariaVisible; }
            set { SetPropertyChanged(ref _ExpansaoMonetariaVisible, value); }
        }

        public bool RetracaoMonetariaVisible
        {
            get { return _RetracaoMonetariaVisible; }
            set { SetPropertyChanged(ref _RetracaoMonetariaVisible, value); }
        }


        public IsLmViewModel()
        {
            ExpansaoFiscalClicked = new Command(ExecuteExpansaoFiscalClicked);
            RetracaoFiscalClicked = new Command(ExecuteRetracaoFiscalClicked);
            ExpansaoMonetariaClicked = new Command(ExecuteExpansaoMonetariaClicked);
            RetracaoMonetariaClicked = new Command(ExecuteRetracaoMonetariaClicked);
            ExpansaoFiscalVisible = false;
            RetracaoFiscalVisible = false;
            ExpansaoMonetariaVisible = false;
            RetracaoMonetariaVisible = false;
            OriginalVisible = true;
        }

        public void ExecuteExpansaoFiscalClicked()
        {
            ExpansaoFiscalVisible = true;
            RetracaoFiscalVisible = false;
            OriginalVisible = false;
        }

        public void ExecuteRetracaoFiscalClicked()
        {
            ExpansaoFiscalVisible = false;
            RetracaoFiscalVisible = true;
            OriginalVisible = false;
        }

        public void ExecuteExpansaoMonetariaClicked()
        {
            ExpansaoMonetariaVisible = true;
            RetracaoMonetariaVisible = false;
            OriginalVisible = false;
        }

        public void ExecuteRetracaoMonetariaClicked()
        {
            ExpansaoMonetariaVisible = false;
            RetracaoMonetariaVisible = true;
            OriginalVisible = false;
        }
    }
}


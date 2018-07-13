using TrabalhoEconomiaOficial.View;
using Xamarin.Forms;

namespace TrabalhoEconomiaOficial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InflacaoPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.Blue,

            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SIAPadlock
{
    public partial class App : Application
    {
		public string user = "alexis";
        public string password = "jass2418";
		public string Url = "https://api.particle.io/v1/devices/25001c001547363332363732";

        public App()
        {
            InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
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

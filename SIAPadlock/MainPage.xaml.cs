using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SIAPadlock
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

		protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000); ;
            await this.Navigation.PushAsync(new LoginPage());
        }
    }
}

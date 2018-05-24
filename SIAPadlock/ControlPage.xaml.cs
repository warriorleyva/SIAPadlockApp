using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SIAPadlock
{
    public partial class ControlPage : ContentPage
    {
        
		public HttpClient PhotonHttpClient = new HttpClient();

        private async Task Move(string parameter)
        {
            var app = Application.Current as App;
            var body = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("access_token", "0f4384bd65ba35fac75ae7ea740214655b485ea4"),
                new KeyValuePair<string, string>("args", parameter),

            };
            var content = new FormUrlEncodedContent(body);
            await PhotonHttpClient.PostAsync(app.Url + "/Move", content);
        }

        public ControlPage()
        {
            InitializeComponent();
        }
        
		private async void Open_Clicked(object sender, System.EventArgs e)
        {
			await Move("DER");
        }

        private async void Close_Clicked(object sender, System.EventArgs e)
        {
			await Move("IZQ");
        }

		async void CloseSession_Clicked(object sender, System.EventArgs e)
		{
			var result = await DisplayAlert("CUIDADO", "Está seguro que desea cerrar la sesión?", "Aceptar", "Cancelar");
			if (result == true)
				await Navigation.PushAsync(new LoginPage());
		}
    }
}

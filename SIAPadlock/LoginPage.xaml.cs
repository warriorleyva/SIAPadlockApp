using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SIAPadlock
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

		async void Login_Clicked(object sender, System.EventArgs e)
		{
			var app = Application.Current as App;

			if (string.IsNullOrEmpty(userEntry.Text))
			{
				await DisplayAlert("Error", "Debe ingresar un usuario", "Aceptar");
				userEntry.Focus();
				return;
			}

			if (string.IsNullOrEmpty(passwordEntry.Text))
			{
				await DisplayAlert("Error", "Debe ingresar la contraseña", "Aceptar");
				passwordEntry.Focus();
				return;
			}

			if ((userEntry.Text == app.user) && (passwordEntry.Text == app.password))
			{
				await Navigation.PushAsync(new ControlPage());
			}

			else
			{
				await DisplayAlert("Error", "El usuario o contraseña son incorrectos", "Aceptar");
			}
		}
    }
}

using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using System;

namespace SmartOrganizer
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var result = await BiometricAuthenticator.AuthenticateAsync(new AuthenticationRequestConfiguration("Login", "U¿yj odcisku palca do logowania"));
            if (result.Authenticated)
            {
                await Shell.Current.GoToAsync("CalendarPage");
            }
            else
            {
                await DisplayAlert("B³¹d", "Logowanie nieudane. Spróbuj ponownie.", "OK");
            }
        }
    }
}
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
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
            var request = new AuthenticationRequestConfiguration("Logowanie", "U�yj odcisku palca, aby si� zalogowa�");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);

            if (result.Authenticated)
            {
                await Shell.Current.GoToAsync("CalendarPage");
            }
            else
            {
                await DisplayAlert("B��d", "Logowanie nieudane. Spr�buj ponownie.", "OK");
            }
        }
    }
}
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace SmartOrganizer
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void OnDarkModeToggled(object sender, ToggledEventArgs e)
        {
            Application.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
        }
    }
}
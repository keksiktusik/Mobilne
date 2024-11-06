using Microsoft.Maui.Controls;
namespace SmartOrganizer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CalendarPage), typeof(CalendarPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        }
    }
}

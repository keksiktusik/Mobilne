using Microsoft.Maui.Controls;

namespace SmartOrganizer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}

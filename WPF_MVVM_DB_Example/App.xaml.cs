using System.Configuration;
using System.Data;
using System.Windows;

namespace WPF_MVVM_DB_Example
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            StartupUri = new Uri("DialogService.Views/LoginWindow.xaml", UriKind.Relative);

        }

    }

}

using GalaSoft.MvvmLight.Ioc;
using System.Configuration;
using System.Data;
using System.Windows;
using WPF_MVVM_DB_Example.DialogService.Defines.Interfaces;
using WPF_MVVM_DB_Example.DialogService.ViewModels;
using WPF_MVVM_DB_Example.DialogService.Views;
using WPF_MVVM_DB_Example.DialogService;


namespace WPF_MVVM_DB_Example
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Bootstrapper.Init();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            StartupUri = new Uri("DialogService/MainWindow.xaml", UriKind.Relative);

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
            dialog.Register<MainWindow>();

            dialog.Set<LoginViewModel, MainWindow>(new LoginViewModel());
        }


    }

}

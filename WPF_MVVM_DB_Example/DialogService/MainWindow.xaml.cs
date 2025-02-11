using GalaSoft.MvvmLight;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_MVVM_DB_Example.DialogService.Defines;
using WPF_MVVM_DB_Example.DialogService.Defines.Interfaces;

namespace WPF_MVVM_DB_Example.DialogService.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDialog
    {
        //private static MainWindow _Instance = null;
        //public static MainWindow GetInstance()
        //{
        //    if(_Instance == null)
        //    {
        //        _Instance = new MainWindow();
        //    }
        //    return _Instance;
        //}

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new MainViewModel();
        }

    }


    public class AppViewModel : ViewModelBase, IDialogContext
    {
        private IContext? _context;

        public IContext? Context
        {
            get => _context;
            set => this.Set(ref this._context, value);
        }
    }
}
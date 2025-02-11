using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using WPF_MVVM_DB_Example.Commands;
using WPF_MVVM_DB_Example.DialogService.Views;
using WPF_MVVM_DB_Example.Models;
using System.Reflection.Metadata;
using System.Windows.Navigation;
using WPF_MVVM_DB_Example.DialogService.Views.Nusring;
using WPF_MVVM_DB_Example.DialogService.Defines.Interfaces;

namespace WPF_MVVM_DB_Example.DialogService.ViewModels
{
    public class LoginViewModel : BaseViewModel, IContext
    {

        TempItemContext db = new TempItemContext();

        private string _id;
        private string _password;


        public string Id
        {

            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Password
        {

            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }




        public ICommand LoginCommand { get; set; }
        public event Action RequestClose;

        public LoginViewModel()
        {

            LoginCommand = new RelayCommand(Login);
        }


        private void Login(object obj)
        {
            PasswordBox pw = (PasswordBox)obj;
            Password = pw.Password;

            int CkNum;

            CkNum = LoginCheck(Id, Password);


            if (CkNum > 0)
            {
                //MainWindow mainWindow = new MainWindow();

                if (CkNum == 1)
                {
                    ////mainWindow.Show();
                    //NursingMain nursingMain = new NursingMain();
                    //LoginWindow loginWindow = new LoginWindow();
                    //NavigationService.GetNavigationService(nursingMain);

                    //NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
                    MessageBox.Show("성공");
                }
                RequestClose?.Invoke();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요.");
            }

        }

        private int LoginCheck(string id, string password)
        {

            int ck = 0;

            if (id != null && password != null)
            {
                var login = db.Employees.SingleOrDefault(f => f.Id == id && f.Password == password);

                if (login != null)
                {
                    ck = 1;
                }

                else ck = 0;
            }

            return ck;

        }

    }
}

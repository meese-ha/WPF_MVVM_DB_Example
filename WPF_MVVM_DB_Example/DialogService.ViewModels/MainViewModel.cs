using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Markup;
using WPF_MVVM_DB_Example.Models;
using WPF_MVVM_DB_Example.Commands;
using System.CodeDom.Compiler;
using System.Security;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WPF_MVVM_DB_Example.DialogService.ViewModels;
namespace WPF_MVVM_DB_Example.DialogService.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        //TempItemContext db = new TempItemContext();


        public MainViewModel()
        {
            Fill();
        }

        private void Fill()
        {


        }


        //private bool canClickEvent(object arg)
        //{
        //    return true;
        //}

        //private void clickEvent(object obj)
        //{
        //    var Login = (object[])obj;

        //    if (Login[0] != null & Login[1] != null)
        //    {
        //        var id = Login[0];

        //        PasswordBox pwbox = (PasswordBox)Login[1];
        //        var pw = pwbox.Password;

        //        LoginCheck(id.ToString(), pw);
        //    } else
        //    {
        //        MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요");
        //    }

        //}

        //private void LoginCheck(string id, string pw)
        //{

        //    if (id != null && pw != null)
        //    {
        //        var login = db.Employees.SingleOrDefault(f => f.Id == id && f.Password == pw);

        //        if (login != null )
        //        {
        //            MessageBox.Show("Good");
        //            //MainWindow mainWindow = MainWindow.GetInstance();
        //            //Uri uri = new Uri("/Nursing/NursingMain.xaml", UriKind.Absolute);
        //            //NavigationService.Navigate(new Uri("/Nursing/NursingMain.xaml", UriKind.Absolute));
        //            //NavigationService.Navigate(uri);

        //            MainWindow mainWindow = MainWindow.GetInstance();
        //            mainWindow.Show();

        //            //mainWindow = new Uri("/Nursing/NursingMain.xaml", UriKind.Relative);

        //            //MessageBox.Show("로그인에 성공하였습니다.");
        //        }
        //        else MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요");
        //    }


        //}

    }
}

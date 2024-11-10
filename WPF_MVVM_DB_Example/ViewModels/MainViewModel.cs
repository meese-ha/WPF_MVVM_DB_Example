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

namespace WPF_MVVM_DB_Example.ViewModels
{
    public class MainViewModel : Base
    {
        TempItemContext db = new TempItemContext();

        public ICommand LoginCommand { get; set; }

        public MainViewModel()
        {
            Fill();
        }

        private void Fill()
        {

            LoginCommand = new LoginCommand(clickEvent, canClickEvent);

        }

        private bool canClickEvent(object arg)
        {
            return true;
        }

        private void clickEvent(object obj)
        {
            var Login = (object[])obj;

            var id = Login[0];

            PasswordBox pwbox = (PasswordBox)Login[1];
            var pw = pwbox.Password;

            if (id != null && pw != null)
            {
                LoginCheck(id.ToString(), pw);
            }
        }

        private  void LoginCheck(string id, string pw)
        {
            //var parameter = (LoginViewModel[])viewModel;

            if (id != null && pw != null)
            {
                var login = db.Employees.SingleOrDefault(f => f.Id == id && f.Password == pw);

                if (login != null )
                {
                    MessageBox.Show("로그인에 성공하였습니다.");
                }
                else MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요");
            }


        }

    }
}

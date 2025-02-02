﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_MVVM_DB_Example.Iinterface;
using WPF_MVVM_DB_Example.ViewModels;

namespace WPF_MVVM_DB_Example.Main
{
    /// <summary>
    /// LoginWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginWindow : Window, IDialog
    {
        public LoginWindow()
        {
            InitializeComponent();

        }



        //private void PasswordChanged(object sender, RoutedEventArgs e)
        //{
        //    if (DataContext is LoginViewModel loginViewModel)
        //    {
        //        loginViewModel.Password = ((PasswordBox)sender).Password;
        //    }
        //}
    }


    class AppViewModel : BaseViewModel, IDialogContext
    {
        private IContext _context;

        public IContext Context
        {
            get => _context;
            set => this.Set(ref _context, value);
        }
    }
}

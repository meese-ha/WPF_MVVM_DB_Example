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
using WPF_MVVM_DB_Example.DataBase;
using WPF_MVVM_DB_Example.Models;
using WPF_MVVM_DB_Example.Commands;
using System.CodeDom.Compiler;
using System.Security;
using System.Windows.Controls;

namespace WPF_MVVM_DB_Example.ViewModels
{
    public class MainViewModel : Base
    {
        TempItemContext db = new TempItemContext();

        private DbSet<TempItem> tempItems;
        public Command checkLogingCommand { get; set; }

        private string _Id;
        private string _Pw;


        public string Id
        {
            get { return _Id;  }
            set 
            { 
                _Id = value;
                NotifyPropertyChanged(nameof(_Id));
            }
        }

        public string Pw
        {
            get { return _Pw; }
            set
            {
                _Pw = value;
                NotifyPropertyChanged(nameof(_Pw));
            }
        }

        public MainViewModel()
        {
            Fill();
        }

        private void Fill()
        {
            tempItems = db.TempItems;
            Collection = new ObservableCollection<TempItem>(tempItems);
            checkLogingCommand = new Command(CheckLogin);
        }

        private bool canexecuteMethod(object arg)
        {
            return true;
        }

        private void executeMethod(object obj)
        {
            throw new NotImplementedException();
        }

        private ObservableCollection<TempItem> _collection;

        public ObservableCollection<TempItem> Collection
        {
            get => _collection;
            set
            {
                _collection = value;
                NotifyPropertyChanged("Collection");
            }

        }

        private  void CheckLogin(object parameters)
        {
            var parameter = (object[])parameters;

            Id = parameter[0] as string;
            var passwordBox = (PasswordBox)parameter[1];
            var value = passwordBox.Password;
        }

    }
}

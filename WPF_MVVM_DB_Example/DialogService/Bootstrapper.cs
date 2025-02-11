using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_DB_Example.DialogService.Defines.Interfaces;

namespace WPF_MVVM_DB_Example.DialogService
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            SimpleIoc.Default.Register<IDialogService, Services.DialogService>();
        }
    }
}

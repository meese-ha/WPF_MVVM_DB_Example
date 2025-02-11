using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_DB_Example.DialogService.Defines.Interfaces
{
    interface IDialogContext
    {
        IContext Context { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_DB_Example.DialogService.Defines.Interfaces
{
    interface IDialogService : IDisposable
    {
        void Register<TDialog>()
            where TDialog : class, IDialog;

        void Set<TContext>(TContext context)
            where TContext : IContext;

        void Set<TContext, TDialog>(TContext context)
            where TContext : IContext
            where TDialog : IDialog;

        bool? SetAwait<TContext>(TContext context)
            where TContext : IContext;

        bool? SetAwait<TContext, TDialog>(TContext context)
            where TContext : IContext
            where TDialog : IDialog;

        void Out<TContext>(TContext context)
            where TContext : IContext;

        void Out<TContext, TDialog>(TContext context)
            where TContext : IContext
            where TDialog : IDialog;

        void Clear();
    }
}

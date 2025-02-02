using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_DB_Example.Iinterface
{
    class DialogService : IDialogService
    {
        private List<Type> _dialogTypes = new List<Type>();

        private List<IDialog> _openedDialogs = new List<IDialog>();

        public void Register<TDialog>()
            where TDialog : class, IDialog
        {
            var type = typeof(TDialog);
            if (this._dialogTypes.Any(d => d.Equals(type)))
            {
                return;
            }

            this._dialogTypes.Add(type);
        }

        public void Set<TContext>(TContext context)
            where TContext : IContext
        {
            this.Set((t) => true, context);
        }

        public void Set<TContext, TDialog>(TContext context)
            where TContext : IContext
            where TDialog : IDialog
        {
            var type = typeof(TDialog);
            this.Set((t) => t.Equals(type), context);
        }

        public bool? SetAwait<TContext>(TContext context)
            where TContext : IContext
        {
            return this.Set((t) => true, context, true);
        }

        public bool? SetAwait<TContext, TDialog>(TContext context)
            where TContext : IContext
            where TDialog : IDialog
        {
            var type = typeof(TDialog);
            return this.Set((t) => t.Equals(type), context, true);
        }

        private bool? Set<TContext>(Func<Type, bool> isExist, TContext context, bool isModal = false)
            where TContext : IContext
        {
            if (this._dialogTypes.Any(isExist) == false)
            {
                throw new NotImplementedException("There is no mathched dialog type");
            }

            var dialogType = this._dialogTypes.First(isExist);
            var dialog = Activator.CreateInstance(dialogType) as IDialog;

            var datacontext = dialog.DataContext as IDialogContext;
            datacontext.Context = context;

            this._openedDialogs.Add(dialog);

            if (isModal == false)
            {
                dialog.Show();

                return null;
            }

            return dialog.ShowDialog();

        }

        public void Out<TContext>(TContext context)
            where TContext : IContext
        {
            this.Out((d) =>
            {
                var datacontext = d.DataContext as IDialogContext;
                return datacontext.Context.Equals(context);

            });
        }

        private void Out(Func<IDialog, bool> isExist)
        {
            var opened = this._openedDialogs.Where(isExist).ToList();

            try
            {
                foreach (var dialog in opened)
                {
                    dialog.Close();
                    dialog.DataContext = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                foreach (var dialog in opened)
                {
                    this._openedDialogs.Remove(dialog);
                }
            }

        }

        public void Out<TContext, TDialog>(TContext context)
            where TContext : IContext
            where TDialog : IDialog
        {
            this.Out((d) =>
            {
                var dialogType = d.GetType();
                return dialogType.Equals(typeof(TDialog));
            });
        }

        public void Clear()
        {
            this._openedDialogs.ForEach(d => 
            {
                try
                {
                    d.Close();
                }
                catch(Exception ex)
                { Console.WriteLine(ex.ToString()); }            
            });
            this._openedDialogs.Clear();
            this._dialogTypes.Clear();
        }

        public void Dispose() 
        {
            this.Clear();
        }



    }
}

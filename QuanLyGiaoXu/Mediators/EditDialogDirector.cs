using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyGiaoXu.Mediators
{
    public interface IDialogDirector<T>
    {
        bool? ShowDialog();
        T Result { get; }
    }

    public interface IDialogViewModel
    {
        event EventHandler RequestClose;
        bool IsEditComplete { get; set; }
    }

    /// <summary>
    /// Abstract EditDialog Mediator
    /// </summary>
    /// <typeparam name="T">Represents the type for the ViewModel Colleague</typeparam>
    public abstract class EditDialogDirector<T> : IDisposable, IDialogDirector<T> where T : IDialogViewModel, new()
    {
        private Window _dlg;
        protected T _vm;

        /// <summary>
        /// Colleague that represents the View. Setting this triggers a set to 
        /// the other Colleague that represents the ViewModel.
        /// </summary>
        public Window Dialog
        {
            get { return _dlg; }
            protected set
            {
                _dlg = value;

                if (_dlg != null)
                {
                    Dispose();

                    _vm = new T();
                    _vm.IsEditComplete = false;
                    _vm.RequestClose += OnRequestClose;

                    _dlg.DataContext = _vm;
                }
            }
        }

        /// <summary>
        /// The resulting changes from the dialog interaction
        /// </summary>
        public T Result
        {
            get { return _vm; }
        }

        /// <summary>
        /// Wrapper to call ShowDialog on the View
        /// </summary>
        /// <returns></returns>
        public bool? ShowDialog()
        {
            if (Dialog != null)
            {
                return Dialog.ShowDialog();
            }
            else
            {
                return false;
            }
        }

        private void OnRequestClose(object sender, EventArgs e)
        {
            if (Dialog != null)
            {
                Dialog.DialogResult = this.Result.IsEditComplete;
            }
        }

        #region IDisposable

        public void Dispose()
        {
            if (_vm != null)
            {
                _vm.RequestClose -= OnRequestClose;
            }
        }

        #endregion IDisposable
    }
}

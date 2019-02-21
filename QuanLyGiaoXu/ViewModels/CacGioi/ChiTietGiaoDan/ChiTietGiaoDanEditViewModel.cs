using EntityTier;
using QuanLyGiaoXu.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan
{
    public class ChiTietGiaoDanEditViewModel : ViewModelBase, IDialogViewModel
    {
        #region Fields

        private GiaoDanEntity _giaodan;
        private bool _isEditComplete;
        private ViewModelBase _currentView;

        private readonly ICommand _saveChangesCommand;
        private readonly ICommand _cancelDialogCommand;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Du lieu giao dan
        /// </summary>
        public GiaoDanEntity GiaoDan
        {
            get { return _giaodan; }
            set
            {
                _giaodan = value;
                OnPropertyChanged("GiaoDan");
            }
        }

        /// <summary>
        /// Flag to track if editing of the item was completed successfully.
        /// </summary>
        public bool IsEditComplete
        {
            get { return _isEditComplete; }
            set
            {
                _isEditComplete = value;
                OnPropertyChanged("IsEditComplete");
            }
        }

        public ViewModelBase CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        #endregion Properties

        #region Contructor

       

        #endregion

        #region Events

        public event EventHandler RequestClose;

        private void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        #endregion Events
    }
}

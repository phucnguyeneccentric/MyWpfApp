using EntityTier;
using QuanLyGiaoXu.Mediators;
using QuanLyGiaoXu.Views.CacGioi.ChiTiet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan
{
    public class ChiTietGiaoDanViewModel : ViewModelBase
    {
        #region Fields

        private GiaoDanEntity _giaodan;
        private ICommand _chitietCommand;

        #endregion Fields

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


        #region Commands

        /// <summary>
        /// Launches the EditItem Dialog
        /// </summary>
        public ICommand ShowChiTietCommand
        {
            get
            {
                if (_chitietCommand == null)
                    _chitietCommand = new RelayCommand(ShowChiTietDialog);


                return _chitietCommand;
            }
            set
            {
                _chitietCommand = value;
                OnPropertyChanged("ShowChiTietCommand");
            }
        }
        public void ShowChiTietDialog()
        {
            // pass the item to the dialog
            var dlg = new ChiTietGiaoDanDirector(GiaoDan);
            if (dlg.ShowDialog() == true)
            {
                // retrieve the updated item from the dialog                                
                GiaoDan = dlg.Result.GiaoDan;
            }
        }
        #endregion Commands


    }
}

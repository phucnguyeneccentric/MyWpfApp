using BusinessTier;
using EntityTier;
using MaterialDesignThemes.Wpf;
using QuanLyGiaoXu.Helpers;
using QuanLyGiaoXu.Mediators;
using QuanLyGiaoXu.ViewModels.GiaoDan;
using QuanLyGiaoXu.Views.GiaoDan.ChiTiet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan
{
    public class ChiTietGiaoDanViewModel : ThemGiaoDanViewModel
    {
        #region Fields

        #region giao dan
        private string _ho;
        private string _ten;
        private string _ngthgnamsinh;
        #endregion

        private ICommand _chitietCommand;

        #endregion Fields

        #region Properties
        #region Thong tin giao dan
        
        /// <summary>
        /// ho
        /// </summary>
        public string Ho
        {
            get { return _ho; }
            set
            {
                _ho = value;
                OnPropertyChanged("Ho");
            }
        }
        /// <summary>
        /// ten
        /// </summary>
        public string Ten
        {
            get { return _ten; }
            set
            {
                _ten = value;
                OnPropertyChanged("Ten");
            }
        }
        /// <summary>
        /// birthday
        /// </summary>
        public string NgThgNamsinh
        {
            get { return _ngthgnamsinh; }
            set
            {
                _ngthgnamsinh = value;
                OnPropertyChanged("NgThgNamsinh");
            }
        }
        #endregion 

        #endregion Properties

        #region Commands

        /// <summary>
        /// Launches the EditItem Dialog
        /// </summary>
        public ICommand ShowChiTietCommand
        {
            get
            {
                if (_chitietCommand == null)
                    _chitietCommand = new AnotherCommandImplementation(ShowChiTietDialog);
                return _chitietCommand;
            }
            set
            {
                _chitietCommand = value;
                OnPropertyChanged("ShowChiTietCommand");
            }
        }

        private async void ShowChiTietDialog(object obj)
        {

            //let's set up!
            var view = new Views.GiaoDan.ChiTiet.ChiTietGiaoDan()
            {
                DataContext = new ChiTietGiaoDanEditViewModel(ID, TenThanh, Ho, Ten, NgaySinh, ThangSinh, NamSinh, GioiTinh, GiaoHo, Gioi, SoDienThoai)
            };
            //show the dialog
            var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);
        }

        private void ClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            // add code here
            if ((int)eventArgs.Parameter == 0) return;
            Console.WriteLine("ID la {0}", (int)eventArgs.Parameter);
            var _gd = GiaoDanServices.GetGiaoDanByID((int)eventArgs.Parameter);
            if(_gd != null)
            {
                ID = _gd.ID;
                TenThanh = _gd.TenThanh;
                Ho = GiaoXuHelper.SplitLastName(_gd.HoTen);
                Ten = GiaoXuHelper.SplitFirstName(_gd.HoTen);
                NgThgNamsinh = GiaoXuHelper.UnionDayMonthYear(_gd.NgaySinh,_gd.ThangSinh,_gd.NamSinh);
                GioiTinh = _gd.GioiTinh;
                GiaoHo = _gd.GiaoHo;
                Gioi = _gd.Gioi;
                SoDienThoai = _gd.SoDienThoai;
            }

            
        }
        #endregion Commands


    }
}

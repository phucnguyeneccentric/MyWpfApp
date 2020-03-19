using MaterialDesignThemes.Wpf;
using QuanLyGiaoXu.Helpers;
using QuanLyGiaoXu.ViewModels.GiaoDan;
using QuanLyGiaoXu.Views.HoatDongMucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyGiaoXu.ViewModels.HoatDongMucVu.ChuyenXu
{
    public class DanhSachChuyenXuViewModel : HoatDongMucVuViewModelBase
    {
        #region Fields
        public override string Name => GiaoXuHelper.ChuyenXu;
        public override string Icon => GiaoXuHelper.ChuyenXuIcon;

        private ICommand _addChuyenXuCommand;

        #endregion
        #region Commands
        /// <summary>
        /// tạo chuyển xứ mới
        /// </summary>
        public ICommand AddChuyenXuCommand
        {
            get
            {
                if (_addChuyenXuCommand == null)
                    _addChuyenXuCommand = new AnotherCommandImplementation(AddChuyenXu);
                return _addChuyenXuCommand;
            }
            set
            {
                _addChuyenXuCommand = value;
                OnPropertyChanged("AddChuyenXuCommand");

            }
        }

        private ChiTietChuyenXuViewModel _vm;
        private async void AddChuyenXu(object obj)
        {

            _vm = new ChiTietChuyenXuViewModel();
            //let's set up a little MVVM, cos that's what the cool kids are doing:
            var view = new ThemChuyenXu();

            //show the dialog
            var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);
            //if ((int)result != 0)
            //{
            //    collection_GiaoDan.Add(_vm);
            //}
        }

        private void ClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            // add code here
            //if ((int)eventArgs.Parameter == 0) return;
            //Console.WriteLine("ID la {0}", (int)eventArgs.Parameter);
            //var _gd = GiaoDanServices.GetGiaoDanByID((int)eventArgs.Parameter);
            //if (_gd != null)
            //{

            //    _vm.ID = _gd.ID;
            //    _vm.TenThanh = _gd.TenThanh;
            //    _vm.NgaySinh = _gd.NgaySinh;
            //    _vm.Ho = GiaoXuHelper.SplitLastName(_gd.HoTen);
            //    _vm.Ten = GiaoXuHelper.SplitFirstName(_gd.HoTen);
            //    _vm.GioiTinh = _gd.GioiTinh;
            //    _vm.GiaoHo = _gd.GiaoHo;
            //    _vm.Gioi = _gd.Gioi;


            //}
        }
        #endregion


    }
}

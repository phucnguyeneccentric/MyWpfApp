using BusinessTier;
using EntityTier;
using MaterialDesignThemes.Wpf;
using QuanLyGiaoXu.Helpers;
using QuanLyGiaoXu.Mediators;
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
    public class ChiTietGiaoDanViewModel : ViewModelBase
    {
        #region Fields

        #region giao dan
        private int _id;
        private string _ho;
        private string _ten;
        private string _magiaodan;
        private string _tenthanh;
        private DateTime _ngaysinh;
        private bool _gioitinh;
        private string _giaoho;
        private string _diachinha;
        private int _gioi;
        private int? _cha;
        private int? _me;

        #endregion

        private ICommand _chitietCommand;

        #endregion Fields

        #region Properties
        #region Thong tin giao dan
        /// <summary>
        /// id giao dan
        /// </summary>
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        /// <summary>
        /// ma giao dan
        /// </summary>
        public string MaGiaoDan
        {
            get { return _magiaodan; }
            set
            {
                _magiaodan = value;
                OnPropertyChanged("MaGiaoDan");
            }
        }
        /// <summary>
        /// ten thanh
        /// </summary>
        public string TenThanh
        {
            get { return _tenthanh; }
            set
            {
                _tenthanh = value;
                OnPropertyChanged("TenThanh");
            }
        }
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
        /// ngay sinh
        /// </summary>
        public DateTime NgaySinh
        {
            get { return _ngaysinh; }
            set
            {
                _ngaysinh = value;
                OnPropertyChanged("NgaySinh");
            }
        }
        /// <summary>
        /// gioi tinh
        /// </summary>
        public bool GioiTinh
        {
            get { return _gioitinh; }
            set
            {
                _gioitinh = value;
                OnPropertyChanged("GioiTinh");
            }
        }
        /// <summary>
        /// giao ho
        /// </summary>
        public string GiaoHo
        {
            get { return _giaoho; }
            set
            {
                _giaoho = value;
                OnPropertyChanged("GiaoHo");
            }
        }
        /// <summary>
        /// dia chi nha
        /// </summary>
        public string Diachinha
        {
            get => _diachinha; set
            {
                _diachinha = value;
                OnPropertyChanged("Diachinha");
            }
        }
        /// <summary>
        /// thuoc gioi
        /// thieu nhi: 0, gioi tre: 1, gia truong: 2, hien mau: 3, cao nien: 4, gioi khac :5
        /// </summary>
        public int Gioi
        {
            get => _gioi; set
            {
                _gioi = value;
                OnPropertyChanged("Gioi");
            }
        }
        /// <summary>
        /// id cua cha
        /// </summary>
        public int? IDCha
        {
            get { return _cha; }
            set
            {
                _cha = value;
                OnPropertyChanged("IDCha");
            }
        }
        /// <summary>
        /// id cua me
        /// </summary>
        public int? IDMe
        {
            get { return _me; }
            set
            {
                _me = value;
                OnPropertyChanged("IDMe");
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
                DataContext = new ChiTietGiaoDanEditViewModel(ID, Ho, Ten, MaGiaoDan, TenThanh, NgaySinh, GioiTinh, Gioi, GiaoHo, Diachinha, IDCha, IDMe)
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
                ID = _gd.id;
                TenThanh = _gd.tenthanh;
                MaGiaoDan = _gd.magiaodan;
                Ho = GiaoXuHelper.SplitLastName(_gd.hoten);
                Ten = GiaoXuHelper.SplitFirstName(_gd.hoten);
                NgaySinh = _gd.ngaysinh;
                GioiTinh = _gd.gioitinh;
                GiaoHo = _gd.giaoho;
                Gioi = _gd.gioi;
                Diachinha = _gd.diachinha;
                IDCha = _gd.cha;
                IDMe = _gd.me;
            }

            
        }
        #endregion Commands


    }
}

using BusinessTier;
using EntityTier;
using DataLayer;
using MaterialDesignExtensions.Model;
using QuanLyGiaoXu.Mediators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Globalization;
using System.Windows;
using System.Text.RegularExpressions;

namespace QuanLyGiaoXu.ViewModels.GiaoDan
{
    public class ThemGiaoDanViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Fields
        private ITextBoxSuggestionsSource m_giaohoSuggestionsSource;
        private IAutocompleteSource m_giadinhSuggestionsSource;
        #region giao dan

        private string _hoten;
        private int _id;
        private string _tenthanh;
        private int _ngaysinh;
        private int _thangsinh;
        private int _namsinh;
        private int _gioi;
        private string _noisinh;
        private bool _gioitinh;
        private string _giaoho;
        private string _tencha;
        private string _tenme;
        private byte[] _anhdaidien;
        private string _sodienthoai;
        private string _nghenghiep;
        #endregion

        #region tinh trang chuyen xu

        
        private DateTime _ngaychuyen { get; set; }
        private string _noichuyen { get; set; }
        private string _thuocgiaoxu { get; set; }
        private string _thuocgiaophan { get; set; }
        #endregion

        #region bi tich
        private string _NguoiRuaToi;
        private string _NguoiDoDauRT;
        private DateTime _NgayRuaToi;
        private string _NoiRuaToi;
        private string _SoRuaToi;
        private DateTime _NgayRLLD;
        private string _NoiRLLD;
        private string _SoRLLD;
        private string _NguoiThemSuc;
        private string _NguoiDoDauTS;
        private DateTime _NgayThemSuc;
        private string _NoiThemSuc;
        private string _SoThemSuc;
        #endregion bi tich

        #region commands
       // private ICommand _creategiaodanCommand;
        #endregion commands

        #endregion Fields

        #region Properties
        public ITextBoxSuggestionsSource GiaoHoSuggestionsSource
        {
            get
            {
                return m_giaohoSuggestionsSource;
            }
        }
        public IAutocompleteSource GiaDinhSource
        {
            get
            {
                return m_giadinhSuggestionsSource;
            }
        }
        #region thong tin giao dan
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
        /// ho va ten
        /// </summary>
        public string HoTen
        {
            get { return _hoten; }
            set
            {
                _hoten = value;
                OnPropertyChanged("HoTen");
            }
        }
        /// <summary>
        /// ngay sinh
        /// </summary>
        public int NgaySinh
        {
            get { return _ngaysinh; }
            set
            {
                _ngaysinh = value;
                OnPropertyChanged("NgaySinh");
            }
        }
        /// <summary>
        /// thang sinh
        /// </summary>
        public int ThangSinh
        {
            get { return _thangsinh; }
            set
            {
                _thangsinh = value;
                OnPropertyChanged("ThangSinh");
            }
        }
        /// <summary>
        /// nam sinh
        /// </summary>
        public int NamSinh
        {
            get { return _namsinh; }
            set
            {
                _namsinh = value;
                OnPropertyChanged("NamSinh");
            }
        }
        /// <summary>
        /// noi sinh
        /// </summary>
        public string NoiSinh
        {
            get { return _noisinh; }
            set
            {
                _noisinh = value;
                OnPropertyChanged("NoiSinh");
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
        /// gioi
        /// </summary>
        public int Gioi
        {
            get { return _gioi; }
            set
            {
                _gioi = value;
                OnPropertyChanged("Gioi");
            }
        }
       
        /// <summary>
        /// ten cha
        /// </summary>
        public string TenCha
        {
            get { return _tencha; }
            set
            {
                _tencha = value;
                OnPropertyChanged("TenCha");
            }
        }
        /// <summary>
        /// ten me
        /// </summary>
        public string TenMe
        {
            get { return _tenme; }
            set
            {
                _tenme = value;
                OnPropertyChanged("TenMe");
            }
        }
        /// <summary>
        /// so dien thoai
        /// </summary>
        public string SoDienThoai
        {
            get { return _sodienthoai; }
            set
            {
                _sodienthoai = value;
                OnPropertyChanged("SoDienThoai");
            }
        }
        /// <summary>
        /// nghe nghiep
        /// </summary>
        public string NgheNghiep
        {
            get { return _nghenghiep; }
            set
            {
                _nghenghiep = value;
                OnPropertyChanged("NgheNghiep");
            }
        }
        /// <summary>
        /// anh dai dien
        /// </summary>
        public byte[] AnhDaiDien
        {
            get { return _anhdaidien; }
            set
            {
                _anhdaidien = value;
                OnPropertyChanged("AnhDaiDien");
            }
        }

        #endregion thong tin giao dan

        #region thong tin ve bi tich

        public string NguoiRuaToi
        {
            get => _NguoiRuaToi; set
            {
                _NguoiRuaToi = value;
                OnPropertyChanged("NguoiRuaToi");

            }
        }

        public string NguoiDoDauRT
        {
            get => _NguoiDoDauRT; set
            {
                _NguoiDoDauRT = value;
                OnPropertyChanged("NguoiDoDauRT");
            }
        }
        public DateTime NgayRuaToi
        {
            get => _NgayRuaToi; set
            {
                _NgayRuaToi = value;
                OnPropertyChanged("NgayRuaToi");
            }
        }
        public string NoiRuaToi
        {
            get => _NoiRuaToi; set
            {
                _NoiRuaToi = value;
                OnPropertyChanged("NoiRuaToi");
            }
        }
        public string SoRuaToi
        {
            get => _SoRuaToi; set
            {
                _SoRuaToi = value;
                OnPropertyChanged("SoRuaToi");
            }
        }
        public DateTime NgayRLLD
        {
            get => _NgayRLLD; set
            {
                _NgayRLLD = value;
                OnPropertyChanged("NgayRLLD");
            }
        }
        public string NoiRLLD
        {
            get => _NoiRLLD; set
            {
                _NoiRLLD = value;
                OnPropertyChanged("NoiRLLD");
            }
        }
        public string SoRLLD
        {
            get => _SoRLLD; set
            {
                _SoRLLD = value;
                OnPropertyChanged("SoRLLD");
            }
        }
        public string NguoiThemSuc
        {
            get => _NguoiThemSuc; set
            {
                _NguoiThemSuc = value;
                OnPropertyChanged("NguoiThemSuc");
            }
        }
        public string NguoiDoDauTS
        {
            get => _NguoiDoDauTS; set
            {
                _NguoiDoDauTS = value;
                OnPropertyChanged("NguoiDoDauTS");
            }
        }
        public DateTime NgayThemSuc
        {
            get => _NgayThemSuc; set
            {
                _NgayThemSuc = value;
                OnPropertyChanged("NgayThemSuc");
            }
        }
        public string NoiThemSuc
        {
            get => _NoiThemSuc; set
            {
                _NoiThemSuc = value;
                OnPropertyChanged("NoiThemSuc");
            }
        }
        public string SoThemSuc
        {
            get => _SoThemSuc; set
            {
                _SoThemSuc = value;
                OnPropertyChanged("SoThemSuc");
            }
        }


        #endregion thong tin ve bi tich

        #region thong tin chuyen xu

        public DateTime NgayChuyen
        {
            get { return _ngaychuyen; }
            set
            {
                _ngaychuyen = value;
                OnPropertyChanged("NgayChuyen");
            }
        }

        public string NoiChuyen
        {
            get { return _noichuyen; }
            set
            {
                _noichuyen = value;
                OnPropertyChanged("NoiChuyen");
            }
        }

        public string ThuocGiaoXu
        {
            get { return _thuocgiaoxu; }
            set
            {
                _thuocgiaoxu = value;
                OnPropertyChanged("ThuocGiaoXu");
            }
        }

        public string ThuocGiaoPhan
        {
            get { return _thuocgiaophan; }
            set
            {
                _thuocgiaophan = value;
                OnPropertyChanged("ThuocGiaoPhan");
            }
        }
        #endregion 

        #endregion Properties

        #region Commands

        #endregion

        #region contructor
        public ThemGiaoDanViewModel()
        {
            Gioi = -1;
            GioiTinh = true;
            m_giaohoSuggestionsSource = new GiaoHoSuggestionsSource();

        }

        #endregion

        #region ValidateErrors
        public string Error => throw new NotImplementedException();


        public string this[string Name]
        {
            get
            {
                string errorMsg = string.Empty;

                switch (Name)
                {

                    case "TenThanh":
                        if (string.IsNullOrEmpty(this.TenThanh))
                            errorMsg = "Tên Thánh không được để trống!";
                        break;
                    case "HoTen":
                        if (string.IsNullOrEmpty(this.HoTen))
                            errorMsg = "Tên giáo dân không được để trống!";
                        break;
                    case "GiaoHo":
                        if (string.IsNullOrEmpty(this.GiaoHo))
                            errorMsg = "Giáo họ không được để trống!";
                        break;
                    case "TenCha":
                        if (string.IsNullOrEmpty(this.TenCha))
                            errorMsg = "Họ tên cha không được để trống!";
                        break;
                    case "TenMe":
                        if (string.IsNullOrEmpty(this.TenMe))
                            errorMsg = "Họ tên mẹ không được để trống!";
                        break;
                    case "Gioi":
                        if (this.Gioi == -1)
                            errorMsg = "Giới không được để trống!";
                        break;
                    case "SoDienThoai":
                        if(!string.IsNullOrEmpty(this.SoDienThoai))
                        {
                            if (!Regex.Match(this.SoDienThoai, @"^-*[0-9,\.?\-?\(?\)?\ ]+$").Success )
                                errorMsg = "Số điện thoại không hợp lệ!";
                        }
                        break;
                        

                }

                return errorMsg;
            }
        }

        #endregion ValidateErrors

        #region Events
        public void CreateGiaoDan()
        {
            
            // them record giao dan
            DataLayer.GiaoDan giaodan = new DataLayer.GiaoDan();
            giaodan.TenThanh = TenThanh;
            giaodan.HoTen = HoTen;

            //add anh dai dien
            giaodan.NgaySinh = NgaySinh;
            giaodan.ThangSinh = ThangSinh;
            giaodan.NamSinh = NamSinh;

            giaodan.NoiSinh = NoiSinh;
            giaodan.GiaoHo = GiaoHo;
            giaodan.GioiTinh = GioiTinh;
            giaodan.Gioi = Gioi;
            giaodan.TenCha = TenCha;
            giaodan.TenMe = TenMe;
            giaodan.SoDienThoai = SoDienThoai;
            giaodan.NgheNghiep = NgheNghiep;
            giaodan.Status = true;

            ID = GiaoDanServices.AddOrUpdateGiaoDan(giaodan);

        }
        #endregion
    }
}

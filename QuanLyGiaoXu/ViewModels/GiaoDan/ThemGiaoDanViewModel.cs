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

namespace QuanLyGiaoXu.ViewModels.GiaoDan
{
    public class ThemGiaoDanViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Fields
        private ITextBoxSuggestionsSource m_giaohoSuggestionsSource;
        #region giao dan
        private string _hoten;
        private int _id;
        private string _magiaodan;
        private string _tenthanh;
        private DateTime _ngaysinh;
        private bool _gioitinh;
        private int? _cha;
        private int? _me;
        #endregion

        #region Dia Chi
        private string _diachinha;
        private string _giaoho;
        private string _giaoxu;
        private string _giaohat;
        private string _giaophan;
        private DateTime _ngaychuyenden;
        private DateTime? _ngaychuyendi;
        #endregion

        #region Gioi
        private int _gioi;
        private DateTime _ngaythamgia;
        private DateTime? _ngayketthuc;
        #endregion 

        private string _fullnamecha;
        private string _codecha;
        private string _codeme;
        private string _fullnameme;
        private bool _isEditComplete;

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
        private ICommand _creategiaodanCommand;
        private ICommand _checkcodecha;
        private ICommand _checkcodeme;
        #endregion commands

        #endregion Fields

        #region Properties
        public ITextBoxSuggestionsSource GiaoHoSuggestionsSource
        {
            get
            {
                return m_giaohoSuggestionsSource;
            }
            set
            {
                m_giaohoSuggestionsSource = value;
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
        /// dia chi
        /// </summary>
        public string DiaChi
        {
            get { return _diachinha; }
            set
            {
                _diachinha = value;
                OnPropertyChanged("DiaChi");
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
        /// giao xu
        /// </summary>
        public string GiaoXu
        {
            get { return _giaoxu; }
            set
            {
                _giaoxu = value;
                OnPropertyChanged("GiaoXu");
            }
        }
        /// <summary>
        /// giao hat
        /// </summary>
        public string GiaoHat
        {
            get { return _giaohat; }
            set
            {
                _giaohat = value;
                OnPropertyChanged("GiaoHat");
            }
        }
        /// <summary>
        /// giao phan
        /// </summary>
        public string GiaoPhan
        {
            get { return _giaophan; }
            set
            {
                _giaophan = value;
                OnPropertyChanged("GiaoPhan");
            }
        }
        /// <summary>
        /// ngay chuyen den
        /// </summary>
        public DateTime NgayChuyenDen
        {
            get { return _ngaychuyenden; }
            set
            {
                _ngaychuyenden = value;
                OnPropertyChanged("NgayChuyenDen");
            }
        }
        /// <summary>
        /// ngay chuyen di
        /// </summary>
        public DateTime? NgayChuyenDi
        {
            get { return _ngaychuyendi; }
            set
            {
                _ngaychuyendi = value;
                OnPropertyChanged("NgayChuyenDi");
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
        /// ngay tham gia
        /// </summary>
        public DateTime NgayThamGia
        {
            get { return _ngaythamgia; }
            set
            {
                _ngaythamgia = value;
                OnPropertyChanged("NgayThamGia");
            }
        }
        /// <summary>
        /// ngay ket thuc
        /// </summary>
        public DateTime? NgayKetThuc
        {
            get { return _ngayketthuc; }
            set
            {
                _ngayketthuc = value;
                OnPropertyChanged("NgayKetThuc");
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

        #endregion thong tin giao dan

        /// <summary>
        /// ten thanh, ho ten cha
        /// </summary>
        public string FullNameCha
        {
            get { return _fullnamecha; }
            set
            {
                _fullnamecha = value;
                OnPropertyChanged("FullNameCha");
            }
        }
        /// <summary>
        /// ma ca nhan cua cha
        /// </summary>
        public string CodeCha
        {
            get { return _codecha; }
            set
            {
                _codecha = value;
                OnPropertyChanged("CodeCha");
            }
        }
        /// <summary>
        /// ma ca nhan cua me
        /// </summary>
        public string CodeMe
        {
            get { return _codeme; }
            set
            {
                _codeme = value;
                OnPropertyChanged("CodeMe");
            }
        }

        /// <summary>
        /// ten thanh, ho ten me
        /// </summary>
        public string FullNameMe
        {
            get { return _fullnameme; }
            set
            {
                _fullnameme = value;
                OnPropertyChanged("FullNameMe");
            }
        }

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
        #endregion Properties

        #region Commands
       
        /// <summary>
        /// kiem tra ma ca nhan cua cha
        /// </summary>
        public ICommand CheckCodeCha
        {
            get
            {
                if (_checkcodecha == null)
                    _checkcodecha = new RelayCommand(
                        () =>
                        {
                            FullNameCha = string.Empty;
                            if (GiaoDanServices.CheckValidCode(CodeCha))
                            {
                                var _hotencha = GiaoDanServices.GetNameGiaoDanByID(IDCha);
                                FullNameCha = _hotencha.tenthanh + ' ' + _hotencha.hoten;
                            }

                        });

                return _checkcodecha;
            }
            set
            {
                _checkcodecha = value;
                OnPropertyChanged("CheckCodeCha");

            }
        }
        /// <summary>
        /// kiem tra ma ca nhan cua me
        /// </summary>
        public ICommand CheckCodeMe
        {
            get
            {
                if (_checkcodeme == null)
                    _checkcodeme = new RelayCommand(
                        () =>
                        {
                            FullNameMe = string.Empty;
                            if (GiaoDanServices.CheckValidCode(CodeMe))
                            {
                                var _hotenme = GiaoDanServices.GetNameGiaoDanByID(IDMe);
                                FullNameMe = _hotenme.tenthanh + ' ' + _hotenme.hoten;
                            }

                        });

                return _checkcodeme;
            }
            set
            {
                _checkcodeme = value;
                OnPropertyChanged("CheckCodeMe");

            }
        }
        

        #endregion

        #region contructor
        public ThemGiaoDanViewModel()
        {
            NgaySinh = DateTime.Now;
            Gioi = -1;
            MaGiaoDan = "----------";
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

                    case "HoTen":
                        if (string.IsNullOrEmpty(this.HoTen))
                            errorMsg = "Tên giáo dân không được để trống!";
                        break;
                    case "CodeCha":
                        if (!string.IsNullOrEmpty(CodeCha) && !GiaoDanServices.CheckValidCode(CodeCha))
                            errorMsg = "Mã cá nhân của cha không đúng!";
                        break;
                    case "CodeMe":
                        if (!string.IsNullOrEmpty(CodeMe) && !GiaoDanServices.CheckValidCode(CodeMe))
                            errorMsg = "Mã cá nhân của me không đúng!";
                        break;
                    case "GiaoHo":
                        if (string.IsNullOrEmpty(this.GiaoHo))
                            errorMsg = "Giáo họ không được để trống!";
                        break;
                    case "GiaoXu":
                        if (string.IsNullOrEmpty(this.GiaoXu))
                            errorMsg = "Giáo xứ không được để trống!";
                        break;
                    case "GiaoHat":
                        if (string.IsNullOrEmpty(this.GiaoHat))
                            errorMsg = "Giáo hạt không được để trống!";
                        break;
                    case "GiaoPhan":
                        if (string.IsNullOrEmpty(this.GiaoPhan))
                            errorMsg = "Giáo phận không được để trống!";
                        break;
                    case "Gioi":
                        if (this.Gioi == -1)
                            errorMsg = "Giới không được để trống!";
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
            giaodan.MaGiaoDan = MaGiaoDan;
            giaodan.TenThanh = TenThanh;
            giaodan.HoTen = HoTen;
            giaodan.NgaySinh = NgaySinh;
            giaodan.GioiTinh = GioiTinh;
            giaodan.Cha = IDCha;
            giaodan.Me = IDMe;
            giaodan.Status = true;
            ID = GiaoDanServices.AddOrUpdateGiaoDan(giaodan);

            // them record dia chi
            DataLayer.DiaChi diachi = new DataLayer.DiaChi();
            diachi.IDGiaoDan = ID;
            diachi.DiaChiNha = DiaChi;
            diachi.GiaoHo = GiaoHo;
            diachi.GiaoXu = "Ngọc Lâm";
            diachi.GiaoHat = "Phương Lâm";
            diachi.GiaoPhan = "Xuân Lộc";
            diachi.NgayChuyenDen = DateTime.Now;
            diachi.NgayChuyenDi = null;
            diachi.Status = true;
            DiaChiServices.AddOrUpdateDiaChi(diachi);

            // them record gioi
            DataLayer.Gioi gioi = new DataLayer.Gioi();
            gioi.IDGiaoDan = ID;
            gioi.Gioi1 = Gioi;
            gioi.NgayThamGia = DateTime.Now;
            gioi.NgayKetThuc = null;
            gioi.Status = true;
            GioiServices.AddOrUpdateGioi(gioi);
        }
        #endregion
    }
}

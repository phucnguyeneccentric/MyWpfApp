using BusinessTier;
using QuanLyGiaoXu.Mediators;
using QuanLyGiaoXu.ViewModels.GiaoDan;
using System;

namespace QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan
{
    public class ChiTietGiaoDanEditViewModel : ThemGiaoDanViewModel
    {
        #region Fields
        private string _tinhtrang;

        #endregion


        #region Properties
        public string TinhTrang
        {
            get { return _tinhtrang; }
            set
            {
                _tinhtrang = value;
                OnPropertyChanged("TinhTrang");
            }
        }
        #endregion
        #region contructor
        public ChiTietGiaoDanEditViewModel(int id, string tenthanh, string ho, string ten, int ngaysinh, int thangsinh, int namsinh, bool gioitinh, string giaoho, int gioi,  string sodienthoai)
        {
            this.ID = id;
            this.TenThanh = tenthanh;
            this.HoTen = ho + ' ' + ten;
            this.NgaySinh = ngaysinh;
            this.ThangSinh = thangsinh;
            this.NamSinh = namsinh;

            this.GioiTinh = gioitinh;
            this.GiaoHo = giaoho;
            this.Gioi = gioi;
            this.SoDienThoai = sodienthoai;

            Initialize();

        }

        private void Initialize()
        {
            DataLayer.GiaoDan giaodan = new DataLayer.GiaoDan();
            giaodan = GiaoDanServices.GetGiaoDanByID(ID);
           
            TenCha = giaodan.TenCha;
            TenMe = giaodan.TenMe;
            NgheNghiep = giaodan.NgheNghiep;
            AnhDaiDien = giaodan.AnhDaiDien;

            
            // thong tin ve tinh trang chuyen xu
            var chuyenxu = GiaoDanServices.GetInfoLeaving(ID);

            // thong tin ve tinh trang qua doi
            var quadoi = GiaoDanServices.GetInfoDeath(ID);

            if (chuyenxu != null)
            {
                TinhTrang = "Đã chuyển xứ";
            }
            else if (quadoi != null)
            {
                TinhTrang = "Đã qua đời";
            }
            else
            {
                TinhTrang = "Đang sinh hoạt tại xứ";
            }

            

            //NgayChuyen = chuyenxu.NgayChuyen;
            //NoiChuyen = chuyenxu.NoiChuyen;
            //ThuocGiaoXu = chuyenxu.ThuocGiaoXu;
            //ThuocGiaoPhan = chuyenxu.ThuocGiaoPhan;

            //thong tin ve tinh trang qua doi
            //add code
        }

        #endregion


        #region Events
        public void SaveInfo()
        {
            Console.WriteLine("ID la {0}", ID);
            

            // update record giao dan
            DataLayer.GiaoDan giaodan = new DataLayer.GiaoDan();

            giaodan.ID = ID;
            giaodan.TenThanh = TenThanh;
            giaodan.HoTen = HoTen;
            // add anh dai dien
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
            GiaoDanServices.AddOrUpdateGiaoDan(giaodan);

            
            
        }
        #endregion

    }
}

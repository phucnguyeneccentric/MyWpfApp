using BusinessTier;
using QuanLyGiaoXu.Mediators;
using QuanLyGiaoXu.ViewModels.GiaoDan;
using System;

namespace QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan
{
    public class ChiTietGiaoDanEditViewModel : ThemGiaoDanViewModel
    {

        #region contructor
        public ChiTietGiaoDanEditViewModel(int id, string ho, string ten, string magiaodan, string tenthanh, DateTime ngaysinh, bool gioitinh, int gioi, string giaoho, string diachinha, int? cha, int? me)
        {
            this.ID = id;
            this.MaGiaoDan = magiaodan;
            this.TenThanh = tenthanh;
            this.HoTen = ho + ' ' + ten;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.GiaoHo = giaoho;
            this.DiaChi = diachinha;
            DataLayer.DiaChi diachi = DiaChiServices.GetDiaChiByIDGiaoDan(ID);
            this.GiaoHo = diachi.GiaoHo;
            this.GiaoXu = diachi.GiaoXu;
            this.GiaoHat = diachi.GiaoHat;
            this.GiaoPhan = diachi.GiaoPhan;

            this.Gioi = gioi;
            this.IDCha = cha;
            this.CodeCha = GiaoDanServices.GetCodeGiaoDanByID(cha);
            var _hotencha = GiaoDanServices.GetNameGiaoDanByID(cha);
            this.FullNameCha = _hotencha.tenthanh + ' ' + _hotencha.hoten;
            this.IDMe = me;
            this.CodeMe = GiaoDanServices.GetCodeGiaoDanByID(me);
            var _hotenme = GiaoDanServices.GetNameGiaoDanByID(me);
            this.FullNameMe = _hotenme.tenthanh + ' ' + _hotenme.hoten;

            this.GiaoHoSuggestionsSource = new GiaoHoSuggestionsSource();

        }

        #endregion


        #region Events
        public void SaveInfo()
        {
            Console.WriteLine("ID la {0}", ID);
            // update record giao dan
            DataLayer.GiaoDan giaodan = new DataLayer.GiaoDan();
            giaodan.ID = ID;
            giaodan.MaGiaoDan = MaGiaoDan;
            giaodan.TenThanh = TenThanh;
            giaodan.HoTen = HoTen;
            giaodan.NgaySinh = NgaySinh;
            giaodan.GioiTinh = GioiTinh;
            giaodan.Cha = IDCha;
            giaodan.Me = IDMe;
            giaodan.Status = true;
            GiaoDanServices.AddOrUpdateGiaoDan(giaodan);

            // update record dia chi
            DataLayer.DiaChi diachi = new DataLayer.DiaChi();
            diachi.IDGiaoDan = ID;
            diachi.DiaChiNha = DiaChi;
            diachi.GiaoHo = GiaoHo;
            diachi.Status = true;
            DiaChiServices.AddOrUpdateDiaChi(diachi);

            // update record gioi
            DataLayer.Gioi gioi = new DataLayer.Gioi();
            gioi.IDGiaoDan = ID;
            gioi.Gioi1 = Gioi;
            gioi.Status = true;
            GioiServices.AddOrUpdateGioi(gioi);
        }
        #endregion

    }
}

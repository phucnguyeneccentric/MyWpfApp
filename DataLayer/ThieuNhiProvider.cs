using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;


namespace DataLayer
{
    public class ThieuNhiProvider : GiaoDanProvider
    {
        public static List<ThieuNhiEntity> GetAllActiveThieuNhi()
        {
            List<ThieuNhiEntity> _Thieunhi = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Thieunhi = (from u in db.GiaoDan
                            join c in db.Gioi on u.ID equals c.IDGiaoDan
                            join v in db.DiaChi on u.ID equals v.IDGiaoDan
                            where (u.Status == true && c.Status == true && c.Gioi1 == 0)
                            select new ThieuNhiEntity
                            {
                                magiaodan = u.MaGiaoDan,
                                tenthanh = u.TenThanh,
                                hoten = u.HoTen,
                                ngaysinh = u.NgaySinh,
                                diachinha = v.DiaChiNha,
                                giaoho = v.GiaoHo,
                                gioitinh = u.GioiTinh
                            }).ToList();


            }
            return _Thieunhi;

        }
    }
}

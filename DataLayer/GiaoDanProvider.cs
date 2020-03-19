using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityTier;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace DataLayer
{
    public abstract class GiaoDanProvider
    {
        
        public static GiaoDan GetActiveGiaoDanByID(int IDGiaoDan)
        {
            GiaoDan _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan where (u.ID == IDGiaoDan && u.Status == true) select u).FirstOrDefault();
            }
            return _Giaodan;
        }

        public static GiaoDan GetGiaoDanByID(int? idGiaoDan)
        {
            GiaoDan _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan
                            where u.ID == idGiaoDan
                            select u).FirstOrDefault();
  
            }
            return _Giaodan;
        }
        public static ChuyenXu GetInfoLeaving(int? idGiaoDan)
        {
            ChuyenXu _chuyenxu = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _chuyenxu = (from u in db.ChuyenXu
                             where u.IDGiaoDan == idGiaoDan
                             select u).FirstOrDefault();

            }
            return _chuyenxu;
        }
        public static QuaDoi GetInfoDeath(int? idGiaoDan)
        {
            QuaDoi _quadoi = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _quadoi = (from u in db.QuaDoi
                           where u.IDGiaoDan == idGiaoDan
                           select u).FirstOrDefault();

            }
            return _quadoi;
        }
        public static GiaoDanEntityShort GetNameGiaoDanByID(int? idGiaoDan)
        {
            GiaoDanEntityShort _Giaodan = new GiaoDanEntityShort();
            
            using (QLGIAOXU db = new QLGIAOXU())
            {
                GiaoDanEntityShort _tmpgiaodan = (from u in db.GiaoDan
                                                  where u.ID == idGiaoDan
                                                  select new GiaoDanEntityShort
                                                  {
                                                      anhdaidien = u.AnhDaiDien,
                                                      hoten = u.HoTen,
                                                      tenthanh = u.TenThanh
                                                  }
                                                  ).FirstOrDefault();
                if (_tmpgiaodan != null) _Giaodan = _tmpgiaodan;
            }
            return _Giaodan;
        }

        public static List<GiaoDan> GetAllActiveGiaoDan()
        {
            List<GiaoDan> _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan
                             where (u.Status == true) 
                             select u).ToList();


            }
            return _Giaodan;

        }
        public static List<GiaoDan> GetAllActiveGiaoDanByName(string tenGiaodan)
        {
            List<GiaoDan> _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan where (u.HoTen.Contains(tenGiaodan) && u.Status == true) select u).ToList();
            }
            return _Giaodan;
        }
      
        public static int AddOrUpdateGiaoDan(GiaoDan giaodan)
        {
            int idgiaodan = 0;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                if(giaodan.ID > 0)
                {
                    GiaoDan _giaodan = db.GiaoDan.Where(u => u.ID == giaodan.ID).FirstOrDefault();
                    if (_giaodan != null)
                    {
                        _giaodan.TenThanh = giaodan.TenThanh;
                        _giaodan.HoTen = giaodan.HoTen;
                        _giaodan.NgaySinh = giaodan.NgaySinh;
                        _giaodan.ThangSinh = giaodan.ThangSinh;
                        _giaodan.NamSinh = giaodan.NamSinh;
                        _giaodan.NoiSinh = giaodan.NoiSinh;
                        _giaodan.GioiTinh = giaodan.GioiTinh;
                        _giaodan.Gioi = giaodan.Gioi;
                        _giaodan.GiaoHo = giaodan.GiaoHo;
                        _giaodan.TenCha = giaodan.TenCha;
                        _giaodan.TenMe = giaodan.TenMe;
                        _giaodan.AnhDaiDien = giaodan.AnhDaiDien;
                        _giaodan.NgheNghiep = giaodan.NgheNghiep;
                        _giaodan.SoDienThoai = giaodan.SoDienThoai;
                        _giaodan.Status = giaodan.Status;

                    }
                }
                else
                {
                    db.GiaoDan.Add(giaodan);
                }
                int x = db.SaveChanges();
                if (x > 0) // The number of objects written to the underlying database, if x==0 that means update objects
                {
                    idgiaodan = giaodan.ID;
                }

            }
            return idgiaodan;
        }
        public static bool DeleteGiaoDan(int idGiaoDan)
        {
            bool isDel = false;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                GiaoDan tmp = db.GiaoDan.Where(u => u.ID == idGiaoDan && u.Status == true).FirstOrDefault();
                if (tmp != null)
                {
                    tmp.Status = false;
                    db.SaveChanges();
                    isDel = true;
                }
            }
            return isDel;
        }
    }
}

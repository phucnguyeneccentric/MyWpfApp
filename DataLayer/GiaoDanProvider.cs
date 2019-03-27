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
        
        public static GiaoDan GetActiveGiaoDanByCode(string maGiaoDan)
        {
            GiaoDan _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan where (u.MaGiaoDan == maGiaoDan && u.Status == true) select u).FirstOrDefault();
            }
            return _Giaodan;
        }

        public static GiaoDanEntityFull GetGiaoDanByID(int? idGiaoDan)
        {
            GiaoDanEntityFull _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan
                            join v in db.DiaChi on u.ID equals v.IDGiaoDan
                            join t in db.Gioi on u.ID equals t.IDGiaoDan
                            where u.ID == idGiaoDan
                            select new GiaoDanEntityFull
                            {
                                id = u.ID,
                                magiaodan = u.MaGiaoDan,
                                tenthanh = u.TenThanh,
                                hoten = u.HoTen,
                                ngaysinh = u.NgaySinh,
                                gioitinh = u.GioiTinh,
                                diachinha = v.DiaChiNha,
                                giaoho = v.GiaoHo,
                                giaohat = v.GiaoHat,
                                giaoxu = v.GiaoXu,
                                giaophan = v.GiaoPhan,
                                ngaychuyenden = v.NgayChuyenDen,
                                ngaychuyendi = v.NgayChuyenDi,
                                gioi = t.Gioi1,
                                cha = u.Cha,
                                me = u.Me
                            }).FirstOrDefault();
  
            }
            return _Giaodan;
        }
        public static bool CheckValidCode(string maGiaoDan)
            {
            bool _valid = false;
            GiaoDan _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan where (u.MaGiaoDan == maGiaoDan) select u).FirstOrDefault();
                if(_Giaodan != null)
                {
                    _valid = true;
                }
            }
            
            return _valid;
        }
        public static GiaoDanEntityShort GetNameGiaoDanByID(int? idGiaoDan)
        {
            GiaoDanEntityShort _Giaodan = new GiaoDanEntityShort();
            _Giaodan.tenthanh = string.Empty;
            _Giaodan.hoten = string.Empty;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                GiaoDanEntityShort _tmpgiaodan = (from u in db.GiaoDan
                                                  where u.ID == idGiaoDan
                                                  select new GiaoDanEntityShort
                                                  {
                                                      hoten = u.HoTen,
                                                      tenthanh = u.TenThanh
                                                  }
                                                  ).FirstOrDefault();
                if (_tmpgiaodan != null) _Giaodan = _tmpgiaodan;
            }
            return _Giaodan;
        }
        public static string GetCodeGiaoDanByID(int? idGiaoDan)
        {
            string _Code = "";
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Code = (from u in db.GiaoDan where u.ID == idGiaoDan select u.MaGiaoDan).FirstOrDefault();
            }
            return _Code;
        }
        public static int GetIDGiaoDanByCode(string maGiaoDan)
        {
            int _idGiaodan = 0;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _idGiaodan = (from u in db.GiaoDan where (u.MaGiaoDan == maGiaoDan && u.Status == true) select u.ID).FirstOrDefault();
            }
            return _idGiaodan;
        }
        public static List<GiaoDanEntityFull> GetAllActiveGiaoDan()
        {
            List<GiaoDanEntityFull> _Giaodan = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _Giaodan = (from u in db.GiaoDan
                             join c in db.Gioi on u.ID equals c.IDGiaoDan
                             join v in db.DiaChi on u.ID equals v.IDGiaoDan
                             where (u.Status == true && c.Status == true) // c.Gioi1 == 0 la thieu nhi
                             select new GiaoDanEntityFull
                             {
                                 id = u.ID,
                                 magiaodan = u.MaGiaoDan,
                                 tenthanh = u.TenThanh,
                                 hoten = u.HoTen,
                                 ngaysinh = u.NgaySinh,
                                 diachinha = v.DiaChiNha,
                                 giaoho = v.GiaoHo,
                                 gioitinh = u.GioiTinh,
                                 cha = u.Cha,
                                 me = u.Me,
                             }).ToList();


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
        public static string GenerateGiaoDanCode(string StName, string Name, string Birthday)
        {
            string _GiaodanCode = "";
            string _Stname = StName.Trim();
            string _Stnamecut = "";
            string _name = Name.Trim();
            string _namecut = "";
            string _birthday =  new string((from c in Birthday
                                            where char.IsDigit(c)
                                            select c).ToArray()); // dd/mm/yyyy => ddmmyyyy
            string _birthdaycut = "";
            
            StringBuilder sb = new StringBuilder(_Stname);
            if (sb[1] == 'Đ')
            {
                sb[1] = 'D';
                _Stname = sb.ToString();
            }
            _Stnamecut = _Stname.Substring(0, 3);

            string[] _splitname = _name.Split(' ');
            for(int index = 0 ;index < _splitname.Length ;index++)
            {
                if(index == _splitname.Length - 1)
                {
                    sb = new StringBuilder(_splitname[index]);
                    if (sb[1] == 'Đ')
                    {
                        sb[1] = 'D';
                    }
                    _namecut.Insert(index, sb.ToString());

                }


                _namecut.Insert(index, _splitname[index].Substring(0, 1));

            }

            _birthdaycut = _birthday.Substring(0, 4);

            _GiaodanCode = _Stnamecut + _namecut + _birthdaycut;
            _GiaodanCode.ToLower();

            using (QLGIAOXU db = new QLGIAOXU())
            {
                int count = 0;
                count = (from u in db.GiaoDan where (u.MaGiaoDan.Contains(_GiaodanCode) && u.Status == true) select u).Count();
                if (count > 0)
                {
                    count++;
                    _GiaodanCode.Insert(0, count.ToString());
                }

            }
                return _GiaodanCode;
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
                        _giaodan.MaGiaoDan = giaodan.MaGiaoDan;
                        _giaodan.TenThanh = giaodan.TenThanh;
                        _giaodan.HoTen = giaodan.HoTen;
                        _giaodan.NgaySinh = giaodan.NgaySinh;
                        _giaodan.GioiTinh = giaodan.GioiTinh;
                        _giaodan.Cha = giaodan.Cha;
                        _giaodan.Me = giaodan.Me;
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
        public static bool DeleteGiaoDan(string maGiaoDan)
        {
            bool isDel = false;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                GiaoDan tmp = db.GiaoDan.Where(u => u.MaGiaoDan == maGiaoDan && u.Status == true).FirstOrDefault();
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

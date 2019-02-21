using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int GetIDGiaoDanByCode(string maGiaoDan)
        {
            int _idGiaodan = 0;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _idGiaodan = (from u in db.GiaoDan where (u.MaGiaoDan == maGiaoDan && u.Status == true) select u.ID).FirstOrDefault();
            }
            return _idGiaodan;
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
        public static int AddOrUpdateGiaoDan(GiaoDan gd)
        {
            int magiaodan = 0;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                GiaoDan tmp = db.GiaoDan.Where(u => u.MaGiaoDan == gd.MaGiaoDan && u.Status == true).FirstOrDefault();
                if (tmp != null)
                {
                    tmp.TenThanh = gd.TenThanh;
                    tmp.HoTen = gd.HoTen;
                    tmp.NgaySinh = gd.NgaySinh;
                    tmp.GioiTinh = gd.GioiTinh;
                }
                else
                {
                    db.GiaoDan.Add(gd);
                }
                int x = db.SaveChanges();
                if (x > 0)
                {
                    magiaodan = x;
                }

            }
            return magiaodan;
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

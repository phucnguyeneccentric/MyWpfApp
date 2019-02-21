using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BiTichProvider
    {
        public static List<BiTich> GetAllBiTich()
        {
            List<BiTich> _listbitich = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _listbitich = (from u in db.BiTich select u).ToList();
            }
            return _listbitich;
        }
        public static BiTich GetBiTich(string maGiaoDan)
        {
            BiTich _bitich = null;
            int _idGiaoDan = GiaoDanProvider.GetIDGiaoDanByCode(maGiaoDan);
            using (QLGIAOXU db = new QLGIAOXU())
            {
                if(_idGiaoDan != 0)
                {
                    _bitich = (from u in db.BiTich where (u.IDGiaoDan == _idGiaoDan) select u).FirstOrDefault();
                }
                
            }
            return _bitich;
        }

        public static int AddOrUpdateBiTich(BiTich biTich)
        {
            int _idGiaoDan = 0;

            using (QLGIAOXU db = new QLGIAOXU())
            {
                BiTich tmp = db.BiTich.Where(u => u.IDGiaoDan == biTich.IDGiaoDan).FirstOrDefault();
                if (tmp != null)
                {
                    tmp.NgayRLLD = biTich.NgayRLLD;
                    tmp.NgayRuaToi = biTich.NgayRuaToi;
                    tmp.NgayThemSuc = biTich.NgayThemSuc;
                    tmp.NguoiDoDauRT = biTich.NguoiDoDauRT;
                    tmp.NguoiDoDauTS = biTich.NguoiDoDauTS;
                    tmp.NguoiRuaToi = biTich.NguoiRuaToi;
                    tmp.NguoiThemSuc = biTich.NguoiThemSuc;
                    tmp.SoRLLD = biTich.SoRLLD;
                    tmp.SoRuaToi = biTich.SoRuaToi;
                    tmp.SoThemSuc = biTich.SoThemSuc;
                    tmp.NoiRLLD = biTich.NoiRLLD;
                    tmp.NoiRuaToi = biTich.NoiRuaToi;
                    tmp.NoiThemSuc = biTich.NoiThemSuc;
                }
                else
                {
                    db.BiTich.Add(biTich);
                }
                int x = db.SaveChanges();
                if (x > 0)
                {
                    _idGiaoDan = x;
                }

            }
            return _idGiaoDan;
        }
    }
}

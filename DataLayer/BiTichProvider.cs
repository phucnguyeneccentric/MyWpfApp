using EntityTier;
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
        public static BiTichEntity GetBiTich(int? idGiaoDan)
        {
            BiTich _tmp = null;
            BiTichEntity _bitich = new BiTichEntity();
            using (QLGIAOXU db = new QLGIAOXU())
            {
                if(idGiaoDan != 0)
                {
                    _tmp = (from u in db.BiTich where (u.IDGiaoDan == idGiaoDan) select u).FirstOrDefault();
                }
                if (_tmp != null)
                {
                    _bitich.NgayRLLD = _tmp.NgayRLLD;
                    _bitich.NgayRuaToi = _tmp.NgayRuaToi;
                    _bitich.NgayThemSuc = _tmp.NgayThemSuc;
                    _bitich.NguoiDoDauRT = _tmp.NguoiDoDauRT;
                    _bitich.NguoiDoDauTS = _tmp.NguoiDoDauTS;
                    _bitich.NguoiRuaToi = _tmp.NguoiRuaToi;
                    _bitich.NguoiThemSuc = _tmp.NguoiThemSuc;
                    _bitich.NoiRLLD = _tmp.NoiRLLD;
                    _bitich.NoiRuaToi = _tmp.NoiRuaToi;
                    _bitich.NoiThemSuc = _tmp.NoiThemSuc;
                    _bitich.SoRLLD = _tmp.SoRLLD;
                    _bitich.SoRuaToi = _tmp.SoRuaToi;
                    _bitich.SoThemSuc = _tmp.SoThemSuc;
                    
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

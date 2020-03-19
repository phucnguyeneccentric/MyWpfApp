using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DiaChiProvider
    {
        public static List<string> GetListGiaoHo()
        {
            List<string> _listgiaoho = null;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                _listgiaoho = (from u in db.GiaoHo select u.TenGiaoHo).Distinct().ToList();
            }
                return _listgiaoho;
        }
        
       

        //public static int AddOrUpdateDiaChi(DiaChi diachi)
        //{
        //    int id = 0;
        //    using (QLGIAOXU db = new QLGIAOXU())
        //    {
        //        DiaChi _diachi = db.DiaChi.Where(u => u.IDGiaoDan == diachi.IDGiaoDan && u.Status == true).FirstOrDefault();
        //        if(_diachi != null)
        //        {
        //            _diachi.IDGiaoDan = diachi.IDGiaoDan;
        //            _diachi.DiaChiNha = diachi.DiaChiNha;
        //            _diachi.GiaoHo = diachi.GiaoHo; //maximum length: 10
        //            _diachi.GiaoXu = diachi.GiaoXu;
        //            _diachi.GiaoHat = diachi.GiaoHat;
        //            _diachi.GiaoPhan = diachi.GiaoPhan;
        //        }
        //        else
        //        {
        //            db.DiaChi.Add(diachi);
        //        }
        //        int x = db.SaveChanges();
        //        if (x > 0) // The number of objects written to the underlying database, if x==0 that means update objects
        //        {
        //            id = diachi.IDGiaoDan;
        //        }

        //    }
        //    return id;
        //}
    }
}

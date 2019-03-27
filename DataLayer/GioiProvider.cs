using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GioiProvider
    {
        public static int AddOrUpdateGioi(Gioi gioi)
        {
            int id = 0;
            using (QLGIAOXU db = new QLGIAOXU())
            {
                Gioi _gioi = db.Gioi.Where(u => u.IDGiaoDan == gioi.IDGiaoDan && u.Status == true).FirstOrDefault();
                if (_gioi != null)
                {
                    _gioi.IDGiaoDan = gioi.IDGiaoDan;
                    _gioi.Gioi1 = gioi.Gioi1;
                }
                else
                {
                    db.Gioi.Add(gioi);
                }
                int x = db.SaveChanges();
                if (x > 0) // The number of objects written to the underlying database, if x==0 that means update objects
                {
                    id = gioi.IDGiaoDan;
                }

            }
            return id;
        }

    }
}

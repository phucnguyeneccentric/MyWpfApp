using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public abstract class GiaoDanServices
    {
       
        public static GiaoDan GetActiveGiaoDanByCode(string maGiaoDan)
        {
            return GiaoDanProvider.GetActiveGiaoDanByCode(maGiaoDan);
        }

        public static List<GiaoDan> GetAllActiveGiaoDanByName(string tenGiaodan)
        {
            return GiaoDanProvider.GetAllActiveGiaoDanByName(tenGiaodan);
        }
        public static int AddOrUpdateGiaoDan(GiaoDan gd)
        {
            return GiaoDanProvider.AddOrUpdateGiaoDan(gd);
        }
        public static bool DeleteGiaoDan(string maGiaoDan)
        {
            return GiaoDanProvider.DeleteGiaoDan(maGiaoDan);
        }
    }
}

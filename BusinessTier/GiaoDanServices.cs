using DataLayer;
using EntityTier;
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
        public static GiaoDanEntityFull GetGiaoDanByID(int? idGiaoDan)
        {
            return GiaoDanProvider.GetGiaoDanByID(idGiaoDan);
        }

        public static bool CheckValidCode(string maGiaoDan)
        {
            return GiaoDanProvider.CheckValidCode(maGiaoDan);
        }
        public static GiaoDanEntityShort GetNameGiaoDanByID(int? idGiaoDan)
        {
            return GiaoDanProvider.GetNameGiaoDanByID(idGiaoDan);
        }
        public static string GetCodeGiaoDanByID(int? idGiaoDan)
        {
            return GiaoDanProvider.GetCodeGiaoDanByID(idGiaoDan);
        }
        public static List<GiaoDan> GetAllActiveGiaoDanByName(string tenGiaodan)
        {
            return GiaoDanProvider.GetAllActiveGiaoDanByName(tenGiaodan);
        }
        public static List<GiaoDanEntityFull> GetAllActiveGiaoDan()
        {
            return GiaoDanProvider.GetAllActiveGiaoDan();
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

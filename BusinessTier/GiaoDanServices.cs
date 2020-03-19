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
       
       
        public static GiaoDan GetGiaoDanByID(int? idGiaoDan)
        {
            return GiaoDanProvider.GetGiaoDanByID(idGiaoDan);
        }
        public static ChuyenXu GetInfoLeaving(int? idGiaoDan)
        {
            return GiaoDanProvider.GetInfoLeaving(idGiaoDan);
        }
        public static QuaDoi GetInfoDeath(int? idGiaoDan)
        {
            return GiaoDanProvider.GetInfoDeath(idGiaoDan);
        }

        public static GiaoDanEntityShort GetNameGiaoDanByID(int? idGiaoDan)
        {
            return GiaoDanProvider.GetNameGiaoDanByID(idGiaoDan);
        }
       
        public static List<GiaoDan> GetAllActiveGiaoDanByName(string tenGiaodan)
        {
            return GiaoDanProvider.GetAllActiveGiaoDanByName(tenGiaodan);
        }
        public static List<GiaoDan> GetAllActiveGiaoDan()
        {
            return GiaoDanProvider.GetAllActiveGiaoDan();
        }
        public static int AddOrUpdateGiaoDan(GiaoDan gd)
        {
            return GiaoDanProvider.AddOrUpdateGiaoDan(gd);
        }
        public static bool DeleteGiaoDan(int idGiaoDan)
        {
            return GiaoDanProvider.DeleteGiaoDan(idGiaoDan);
        }
    }
}

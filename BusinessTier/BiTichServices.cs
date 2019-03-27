using DataLayer;
using EntityTier;

namespace BusinessTier
{
    public class BiTichServices
    {
        public static BiTichEntity GetBiTich(int? idGiaoDan)
        {
            return BiTichProvider.GetBiTich(idGiaoDan);
        }
        public static int AddOrUpdateBiTich(BiTich biTich)
        {
            return BiTichProvider.AddOrUpdateBiTich(biTich);
        }

    }
}

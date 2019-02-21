using DataLayer;

namespace BusinessTier
{
    public class BiTichServices
    {
        public static BiTich GetBiTich(string maGiaoDan)
        {
            return BiTichProvider.GetBiTich(maGiaoDan);
        }
        public static int AddOrUpdateBiTich(BiTich biTich)
        {
            return BiTichProvider.AddOrUpdateBiTich(biTich);
        }

    }
}

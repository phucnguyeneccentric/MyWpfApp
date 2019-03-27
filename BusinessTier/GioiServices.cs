using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessTier
{
    public class GioiServices
    {
        public static int AddOrUpdateGioi(Gioi gioi)
        {
            return GioiProvider.AddOrUpdateGioi(gioi);
        }
    }
}

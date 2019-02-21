using System;
using System.Collections.Generic;
using System.Text;
using EntityTier;
using DataLayer;



namespace BusinessTier
{
    public class ThieuNhiServices : GiaoDanServices
    {
        public static List<ThieuNhiEntity> GetAllActiveThieuNhi()
        {
            return ThieuNhiProvider.GetAllActiveThieuNhi();
        }

       
    }
}

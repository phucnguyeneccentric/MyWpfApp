using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessTier
{
    public class DiaChiServices 
    {
        public static List<string> GetListGiaoHo()
        {
            return DiaChiProvider.GetListGiaoHo();
        }
        public static DiaChi GetDiaChiByIDGiaoDan(int idgiaodan)
        {
            return DiaChiProvider.GetDiaChiByIDGiaoDan(idgiaodan);
        }
        public static int AddOrUpdateDiaChi(DiaChi diachi)
        {
            return DiaChiProvider.AddOrUpdateDiaChi(diachi);
        }
    }
    
}

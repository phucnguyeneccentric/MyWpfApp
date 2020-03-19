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
      
    }
    
}

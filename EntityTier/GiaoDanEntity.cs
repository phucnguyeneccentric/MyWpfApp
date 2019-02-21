using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public abstract class GiaoDanEntity
    {
        public string magiaodan { get; set; }
        public string tenthanh { get; set; }
        public string hoten { get; set; }
        public System.DateTime ngaysinh { get; set; }
        public bool gioitinh { get; set; }
        public string diachinha { get; set; }
        public string giaoho { get; set; }
        public int gioi;


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public class GiaoDanEntityFull
    {
        public int id { get; set; }
        public string magiaodan { get; set; }
        public string tenthanh { get; set; }
        public string hoten { get; set; }
        public DateTime ngaysinh { get; set; }
        public bool gioitinh { get; set; }
        public string diachinha { get; set; }
        public string giaoho { get; set; }
        public string giaoxu { get; set; }
        public string giaohat { get; set; }
        public string giaophan { get; set; }
        public DateTime ngaychuyenden { get; set; }
        public DateTime? ngaychuyendi { get; set; }
        public int gioi { get; set; }
        public int? cha { get; set; }
        public int? me { get; set; }
    }
    public class GiaoDanEntityShort
    {
        public string tenthanh { get; set; }
        public string hoten { get; set; }
    }
}

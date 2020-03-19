using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DataLayer
{
    [Table("ChuyenXu")]
    public class ChuyenXu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int IDGiaoDan { get; set; }
        /// <summary>
        /// Type:
        /// 1. chuyen den
        /// 2. chuyen di
        /// </summary>
        public int Type { get; set; }
        [Column(TypeName = "date")] 
        public DateTime NgayChuyen { get; set; }
        public string NoiChuyen { get; set; }
        public string ThuocGiaoXu { get; set; }
        public string ThuocGiaoPhan { get; set; }
    }
}

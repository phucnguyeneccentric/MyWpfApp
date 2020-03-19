using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DataLayer
{
    [Table("HonPhoi")]
    public class HonPhoi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int NguoiNam { get; set; }
        public int NguoiNu { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayRaoLan1 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayRaoLan2 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayRaoLan3 { get; set; }
        public string NguoiChungNam { get; set; }
        public string NguoiChungNu { get; set; }
        public string SoHonPhoi { get; set; }
        public string NoiHonPhoi { get; set; }
        public string LinhMucChung { get; set; }
    }
}

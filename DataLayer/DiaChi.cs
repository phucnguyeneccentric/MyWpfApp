namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaChi")]
    public partial class DiaChi
    {
        public int ID { get; set; }

        public int IDGiaoDan { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChiNha { get; set; }

        [Required]
        [StringLength(10)]
        public string GiaoHo { get; set; }

        [Required]
        [StringLength(10)]
        public string GiaoXu { get; set; }

        [Required]
        [StringLength(10)]
        public string GiaoHat { get; set; }

        [Required]
        [StringLength(10)]
        public string GiaoPhan { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayChuyenDen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayChuyenDi { get; set; }

        public bool Status { get; set; }

        public virtual GiaoDan GiaoDan { get; set; }
    }
}

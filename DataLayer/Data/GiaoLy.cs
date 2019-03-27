namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoLy")]
    public partial class GiaoLy
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDGiaoDan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ChuongTrinhGiaoLy { get; set; }

        [Required]
        [StringLength(10)]
        public string PhongHoc { get; set; }

        public double? DiemTrungBinh { get; set; }

        public int? DiemChuyenCan { get; set; }

        [StringLength(10)]
        public string XepLoai { get; set; }

        public bool Status { get; set; }

        public virtual ChuongTrinhGiaoLy ChuongTrinhGiaoLy1 { get; set; }
    }
}

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

        public int IDGiaDinh { get; set; }

        [StringLength(50)]
        public string SoNha { get; set; }

        [StringLength(50)]
        public string Ap { get; set; }

        [StringLength(50)]
        public string Xa { get; set; }

        [StringLength(50)]
        public string Huyen { get; set; }

        [StringLength(50)]
        public string Tinh { get; set; }

        [Required]
        [StringLength(20)]
        public string GiaoHo { get; set; }

        public DateTime NgayChuyenDen { get; set; }

        public DateTime? NgayChuyenDi { get; set; }

        public bool Status { get; set; }

        public virtual GiaDinh GiaDinh { get; set; }
    }
}

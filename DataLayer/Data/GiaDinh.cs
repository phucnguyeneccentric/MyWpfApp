namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaDinh")]
    public partial class GiaDinh
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGiaDinh { get; set; }

        public int ChuHo { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(20)]
        public string GiaoHo { get; set; }

        [Required]
        [StringLength(20)]
        public string GiaoXu { get; set; }

        [Required]
        [StringLength(20)]
        public string GIaoHat { get; set; }

        [Required]
        [StringLength(20)]
        public string GiaoPhan { get; set; }

        public bool Status { get; set; }
    }
}

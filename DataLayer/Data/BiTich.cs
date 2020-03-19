namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BiTich")]
    public partial class BiTich
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int IDGiaoDan { get; set; }

        [StringLength(50)]
        public string NguoiRuaToi { get; set; }

        [StringLength(50)]
        public string NguoiDoDauRT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayRuaToi { get; set; }

        [StringLength(20)]
        public string NoiRuaToi { get; set; }

        [StringLength(10)]
        public string SoRuaToi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayRLLD { get; set; }

        [StringLength(20)]
        public string NoiRLLD { get; set; }

        [StringLength(10)]
        public string SoRLLD { get; set; }

        [StringLength(50)]
        public string NguoiThemSuc { get; set; }

        [StringLength(50)]
        public string NguoiDoDauTS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThemSuc { get; set; }

        [StringLength(20)]
        public string NoiThemSuc { get; set; }

        [StringLength(10)]
        public string SoThemSuc { get; set; }

        public virtual GiaoDan GiaoDan { get; set; }
    }
}

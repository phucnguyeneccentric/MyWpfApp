namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuongTrinhGiaoLy")]
    public partial class ChuongTrinhGiaoLy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuongTrinhGiaoLy()
        {
            GiaoLy = new HashSet<GiaoLy>();
        }

        [Key]
        [StringLength(10)]
        public string MaChuongTrinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKhaiGiang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public byte Khoi { get; set; }

        [Required]
        [StringLength(10)]
        public string Cap { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoLy> GiaoLy { get; set; }
    }
}

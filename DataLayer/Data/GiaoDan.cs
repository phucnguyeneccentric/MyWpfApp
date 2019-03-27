namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoDan")]
    public partial class GiaoDan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoDan()
        {
            BiTich = new HashSet<BiTich>();
            DiaChi = new HashSet<DiaChi>();
            Gioi = new HashSet<Gioi>();
            GiaoDan1 = new HashSet<GiaoDan>();
            GiaoDan11 = new HashSet<GiaoDan>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(16)]
        public string MaGiaoDan { get; set; }

        [Required]
        [StringLength(20)]
        public string TenThanh { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        public int? Cha { get; set; }

        public int? Me { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BiTich> BiTich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gioi> Gioi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoDan> GiaoDan1 { get; set; }

        public virtual GiaoDan GiaoDan2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoDan> GiaoDan11 { get; set; }

        public virtual GiaoDan GiaoDan3 { get; set; }
    }
}

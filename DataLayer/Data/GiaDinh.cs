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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaDinh()
        {
            DiaChi = new HashSet<DiaChi>();
        }
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string MaGiaDinh { get; set; }

        public int ChuHo { get; set; }

        public int NguoiNam { get; set; }

        public int NguoiNu { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChi { get; set; }
    }
}

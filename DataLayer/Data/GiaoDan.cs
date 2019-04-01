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

        [StringLength(50)]
        public string NoiSinh { get; set; }

        public byte[] AnhDaiDien { get; set; }

        /// <summary>
        /// gioi cua giao dan:
        /// 0. gioi thieu nhi
        /// 1. gioi tre
        /// 2. gioi gia truong
        /// 3. gioi hien mau
        /// 4. gioi cao nien
        /// </summary>
        [Required]
        public int Gioi { get; set; }

        public bool GioiTinh { get; set; }

        /// <summary>
        /// tinh hinh hien tai cua giao dan
        /// 1. dang sinh hoat trong xu
        /// 2. da chuyen xu
        /// 3. da qua doi
        /// </summary>
        [Required]
        public int TinhTrang { get; set; }

        [StringLength(20)]
        public string NgheNghiep { get; set; }



        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BiTich> BiTich { get; set; }


    }
}

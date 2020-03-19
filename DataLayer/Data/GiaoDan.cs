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

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string TenThanh { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public int NgaySinh { get; set; }

        public int ThangSinh { get; set; }

        public int NamSinh { get; set; }

        [StringLength(50)]
        public string NoiSinh { get; set; }


        [StringLength(30)]
        public string GiaoHo { get; set; }

        [StringLength(50)]
        public string TenCha { get; set; }

        [StringLength(50)]
        public string TenMe { get; set; }

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

        [StringLength(30)]
        public string NgheNghiep { get; set; }

        [Phone]
        public string SoDienThoai { get; set; }

        public bool Status { get; set; }

       


    }
}

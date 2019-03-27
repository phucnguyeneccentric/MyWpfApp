namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gioi")]
    public partial class Gioi
    {
        public int ID { get; set; }

        public int IDGiaoDan { get; set; }

        [Column("Gioi")]
        public int Gioi1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThamGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public bool Status { get; set; }

        public virtual GiaoDan GiaoDan { get; set; }
    }
}

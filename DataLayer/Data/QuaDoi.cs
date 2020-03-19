using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DataLayer
{
    [Table("QuaDoi")]
    public class QuaDoi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int IDGiaoDan { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgayMat { get; set; }
        public string NoiMat { get; set; }
        public string So { get; set; }
        public string NoiAnTang { get; set; }
    }
}

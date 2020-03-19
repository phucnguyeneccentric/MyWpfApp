using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DataLayer
{
    [Table("QuanHeGiaDinh")]
    public class QuanHeGiaDinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int IDGiaDinh { get; set; }

        public int IDThanhVien { get; set; }

        public string QuanHeVoiChuHo { get; set; }

        public string GhiChu { get; set; }


    }
}

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLGIAOXU : DbContext
    {
        public QLGIAOXU()
            : base("name=QLGIAOXU")
        {

        }

        public virtual DbSet<BiTich> BiTich { get; set; }
        public virtual DbSet<HonPhoi> HonPhoi { get; set; }
        public virtual DbSet<DiaChi> DiaChi { get; set; }
        public virtual DbSet<GiaDinh> GiaDinh { get; set; }
        public virtual DbSet<QuanHeGiaDinh> QuanHeGiaDinh { get; set; }
        public virtual DbSet<GiaoDan> GiaoDan { get; set; }
        public virtual DbSet<ChuyenXu> ChuyenXu { get; set; }
        public virtual DbSet<QuaDoi> QuaDoi { get; set; }
        public virtual DbSet<GiaoHo> GiaoHo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BiTich>()
                .Property(e => e.SoRuaToi)
                .IsUnicode(false);

            modelBuilder.Entity<BiTich>()
                .Property(e => e.SoRLLD)
                .IsUnicode(false);

            modelBuilder.Entity<BiTich>()
                .Property(e => e.SoThemSuc)
                .IsUnicode(false);

          
        }
    }
}

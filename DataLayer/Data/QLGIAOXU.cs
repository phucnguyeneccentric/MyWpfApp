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
        public virtual DbSet<ChuongTrinhGiaoLy> ChuongTrinhGiaoLy { get; set; }
        public virtual DbSet<DiaChi> DiaChi { get; set; }
        public virtual DbSet<GiaDinh> GiaDinh { get; set; }
        public virtual DbSet<GiaoDan> GiaoDan { get; set; }
        public virtual DbSet<GiaoLy> GiaoLy { get; set; }
        public virtual DbSet<Gioi> Gioi { get; set; }
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

            modelBuilder.Entity<ChuongTrinhGiaoLy>()
                .Property(e => e.MaChuongTrinh)
                .IsFixedLength();

            modelBuilder.Entity<ChuongTrinhGiaoLy>()
                .Property(e => e.Cap)
                .IsFixedLength();

            modelBuilder.Entity<ChuongTrinhGiaoLy>()
                .HasMany(e => e.GiaoLy)
                .WithRequired(e => e.ChuongTrinhGiaoLy1)
                .HasForeignKey(e => e.ChuongTrinhGiaoLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaDinh>()
                .Property(e => e.MaGiaDinh)
                .IsFixedLength();

            modelBuilder.Entity<GiaoDan>()
                .Property(e => e.MaGiaoDan)
                .IsFixedLength();

            modelBuilder.Entity<GiaoDan>()
                .HasMany(e => e.BiTich)
                .WithRequired(e => e.GiaoDan)
                .HasForeignKey(e => e.IDGiaoDan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaoDan>()
                .HasMany(e => e.DiaChi)
                .WithRequired(e => e.GiaoDan)
                .HasForeignKey(e => e.IDGiaoDan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaoDan>()
                .HasMany(e => e.Gioi)
                .WithRequired(e => e.GiaoDan)
                .HasForeignKey(e => e.IDGiaoDan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiaoDan>()
                .HasMany(e => e.GiaoDan1)
                .WithOptional(e => e.GiaoDan2)
                .HasForeignKey(e => e.Cha);

            modelBuilder.Entity<GiaoDan>()
                .HasMany(e => e.GiaoDan11)
                .WithOptional(e => e.GiaoDan3)
                .HasForeignKey(e => e.Me);

            modelBuilder.Entity<GiaoLy>()
                .Property(e => e.ChuongTrinhGiaoLy)
                .IsFixedLength();
        }
    }
}

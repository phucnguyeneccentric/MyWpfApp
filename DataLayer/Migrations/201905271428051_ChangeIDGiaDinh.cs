namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIDGiaDinh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BiTich",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDGiaoDan = c.Int(nullable: false),
                        NguoiRuaToi = c.String(maxLength: 50),
                        NguoiDoDauRT = c.String(maxLength: 50),
                        NgayRuaToi = c.DateTime(storeType: "date"),
                        NoiRuaToi = c.String(maxLength: 20),
                        SoRuaToi = c.String(maxLength: 10, unicode: false),
                        NgayRLLD = c.DateTime(storeType: "date"),
                        NoiRLLD = c.String(maxLength: 20),
                        SoRLLD = c.String(maxLength: 10, unicode: false),
                        NguoiThemSuc = c.String(maxLength: 50),
                        NguoiDoDauTS = c.String(maxLength: 50),
                        NgayThemSuc = c.DateTime(storeType: "date"),
                        NoiThemSuc = c.String(maxLength: 20),
                        SoThemSuc = c.String(maxLength: 10, unicode: false),
                        GiaoDan_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GiaoDan", t => t.GiaoDan_ID)
                .Index(t => t.GiaoDan_ID);
            
            CreateTable(
                "dbo.GiaoDan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaGiaoDan = c.String(nullable: false, maxLength: 16, fixedLength: true),
                        TenThanh = c.String(nullable: false, maxLength: 20),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        NgaySinh = c.DateTime(nullable: false, storeType: "date"),
                        NoiSinh = c.String(maxLength: 50),
                        NamSinh = c.Int(),
                        QuanHeVoiChuHo = c.String(),
                        AnhDaiDien = c.Binary(),
                        Gioi = c.Int(nullable: false),
                        GioiTinh = c.Boolean(nullable: false),
                        TinhTrang = c.Int(nullable: false),
                        NgheNghiep = c.String(maxLength: 30),
                        SoDienThoai = c.String(),
                        TanTong = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ChuyenXu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDGiaoDan = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        NgayChuyen = c.DateTime(nullable: false, storeType: "date"),
                        NoiChuyen = c.String(),
                        ThuocGiaoXu = c.String(),
                        ThuocGiaoPhan = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DiaChi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDGiaDinh = c.Int(nullable: false),
                        SoNha = c.String(maxLength: 50),
                        Ap = c.String(maxLength: 50),
                        Xa = c.String(maxLength: 50),
                        Huyen = c.String(maxLength: 50),
                        Tinh = c.String(maxLength: 50),
                        GiaoHo = c.String(nullable: false, maxLength: 20),
                        GiaoXu = c.String(nullable: false, maxLength: 20),
                        GiaoHat = c.String(nullable: false, maxLength: 20),
                        GiaoPhan = c.String(nullable: false, maxLength: 20),
                        NgayChuyenDen = c.DateTime(nullable: false),
                        NgayChuyenDi = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        GiaDinh_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GiaDinh", t => t.GiaDinh_ID)
                .Index(t => t.GiaDinh_ID);
            
            CreateTable(
                "dbo.GiaDinh",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenGiaDinh = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        ChuHo = c.Int(nullable: false),
                        NguoiNam = c.Int(nullable: false),
                        NguoiNu = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GiaoHo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenGiaoHo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HonPhoi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NguoiNam = c.Int(nullable: false),
                        NguoiNu = c.Int(nullable: false),
                        NgayRaoLan1 = c.DateTime(storeType: "date"),
                        NgayRaoLan2 = c.DateTime(storeType: "date"),
                        NgayRaoLan3 = c.DateTime(storeType: "date"),
                        NguoiChungNam = c.String(),
                        NguoiChungNu = c.String(),
                        SoHonPhoi = c.String(),
                        NoiHonPhoi = c.String(),
                        LinhMucChung = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.QuaDoi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDGiaoDan = c.Int(nullable: false),
                        NgayMat = c.DateTime(nullable: false, storeType: "date"),
                        NoiMat = c.String(),
                        So = c.String(),
                        NoiAnTang = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.QuanHeGiaDinh",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDGiaDinh = c.Int(nullable: false),
                        IDThanhVien = c.Int(nullable: false),
                        QuanHeVoiChuHo = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiaChi", "GiaDinh_ID", "dbo.GiaDinh");
            DropForeignKey("dbo.BiTich", "GiaoDan_ID", "dbo.GiaoDan");
            DropIndex("dbo.DiaChi", new[] { "GiaDinh_ID" });
            DropIndex("dbo.BiTich", new[] { "GiaoDan_ID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.QuanHeGiaDinh");
            DropTable("dbo.QuaDoi");
            DropTable("dbo.HonPhoi");
            DropTable("dbo.GiaoHo");
            DropTable("dbo.GiaDinh");
            DropTable("dbo.DiaChi");
            DropTable("dbo.ChuyenXu");
            DropTable("dbo.GiaoDan");
            DropTable("dbo.BiTich");
        }
    }
}

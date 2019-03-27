namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLengthDiaChi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DiaChi", "DiaChiNha", c => c.String(maxLength: 100));
            AlterColumn("dbo.DiaChi", "GiaoHo", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.DiaChi", "GiaoXu", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.DiaChi", "GiaoHat", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.DiaChi", "GiaoPhan", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DiaChi", "GiaoPhan", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DiaChi", "GiaoHat", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DiaChi", "GiaoXu", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DiaChi", "GiaoHo", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DiaChi", "DiaChiNha", c => c.String(maxLength: 50));
        }
    }
}

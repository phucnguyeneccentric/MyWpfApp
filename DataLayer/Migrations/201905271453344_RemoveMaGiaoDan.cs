namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMaGiaoDan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GiaDinh", "TenGiaDinh", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.GiaoDan", "MaGiaoDan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GiaoDan", "MaGiaoDan", c => c.String(nullable: false, maxLength: 16, fixedLength: true));
            AlterColumn("dbo.GiaDinh", "TenGiaDinh", c => c.String(nullable: false, maxLength: 20, fixedLength: true));
        }
    }
}

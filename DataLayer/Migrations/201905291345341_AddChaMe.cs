namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChaMe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiaoDan", "TenCha", c => c.String(maxLength: 50));
            AddColumn("dbo.GiaoDan", "TenMe", c => c.String(maxLength: 50));
            DropColumn("dbo.GiaoDan", "TinhTrang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GiaoDan", "TinhTrang", c => c.Int(nullable: false));
            DropColumn("dbo.GiaoDan", "TenMe");
            DropColumn("dbo.GiaoDan", "TenCha");
        }
    }
}

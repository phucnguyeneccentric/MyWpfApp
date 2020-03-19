namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTanTong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiaoDan", "GiaoHo", c => c.String(maxLength: 30));
            DropColumn("dbo.GiaoDan", "TanTong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GiaoDan", "TanTong", c => c.Boolean(nullable: false));
            DropColumn("dbo.GiaoDan", "GiaoHo");
        }
    }
}

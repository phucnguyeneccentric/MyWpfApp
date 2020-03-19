namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveQuanHeChuHo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GiaoDan", "QuanHeVoiChuHo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GiaoDan", "QuanHeVoiChuHo", c => c.String());
        }
    }
}

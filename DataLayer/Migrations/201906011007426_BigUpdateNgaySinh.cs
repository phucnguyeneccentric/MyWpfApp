namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BigUpdateNgaySinh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiaoDan", "ThangSinh", c => c.Int(nullable: false));
            AlterColumn("dbo.GiaoDan", "NgaySinh", c => c.Int(nullable: false));
            AlterColumn("dbo.GiaoDan", "NamSinh", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GiaoDan", "NamSinh", c => c.Int());
            AlterColumn("dbo.GiaoDan", "NgaySinh", c => c.DateTime(storeType: "date"));
            DropColumn("dbo.GiaoDan", "ThangSinh");
        }
    }
}

namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NgaySinhCanBeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GiaoDan", "NgaySinh", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GiaoDan", "NgaySinh", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}

namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotRequireDiachi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DiaChi", "DiaChiNha", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DiaChi", "DiaChiNha", c => c.String(nullable:false, maxLength: 50));
        }
    }
}

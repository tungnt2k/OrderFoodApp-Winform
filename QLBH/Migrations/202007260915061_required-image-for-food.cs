namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredimageforfood : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "Content", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Foods", "Content", c => c.Binary());
        }
    }
}

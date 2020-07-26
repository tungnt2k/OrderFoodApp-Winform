namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimagetofood : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Content", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Content");
        }
    }
}

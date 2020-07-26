namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtotalpricecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "TotalPrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bills", "TotalPrice");
        }
    }
}

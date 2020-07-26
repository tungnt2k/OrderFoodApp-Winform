namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumnCustomerNameintableBill : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "CustomerName", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bills", "CustomerName");
        }
    }
}

namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatefoodproperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodCategories", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodCategories", "Name", c => c.String());
        }
    }
}

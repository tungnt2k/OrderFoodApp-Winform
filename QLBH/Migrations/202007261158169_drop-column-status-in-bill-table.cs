namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropcolumnstatusinbilltable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bills", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bills", "Status", c => c.Boolean(nullable: false));
        }
    }
}

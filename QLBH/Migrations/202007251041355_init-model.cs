namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodId = c.Int(nullable: false),
                        BillId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        UpdateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .Index(t => t.FoodId)
                .Index(t => t.BillId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Checkout = c.DateTime(nullable: false),
                        CustomerTake = c.Single(nullable: false),
                        ReturnCustomer = c.Single(nullable: false),
                        Status = c.Boolean(nullable: false),
                        StaffId = c.Int(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        UpdateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DislayName = c.String(maxLength: 100),
                        Username = c.String(maxLength: 50),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        UpdateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Price = c.Single(nullable: false),
                        FoodCategoryId = c.Int(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        UpdateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodCategories", t => t.FoodCategoryId, cascadeDelete: true)
                .Index(t => t.FoodCategoryId);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateAt = c.DateTime(nullable: false),
                        UpdateAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories");
            DropForeignKey("dbo.BillInfoes", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Bills", "StaffId", "dbo.Users");
            DropForeignKey("dbo.BillInfoes", "BillId", "dbo.Bills");
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            DropIndex("dbo.Bills", new[] { "StaffId" });
            DropIndex("dbo.BillInfoes", new[] { "BillId" });
            DropIndex("dbo.BillInfoes", new[] { "FoodId" });
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Foods");
            DropTable("dbo.Users");
            DropTable("dbo.Bills");
            DropTable("dbo.BillInfoes");
        }
    }
}

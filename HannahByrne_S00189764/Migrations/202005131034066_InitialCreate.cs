namespace HannahByrne_S00189764.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Price = c.Double(nullable: false),
                        OperatingSystem = c.String(),
                        OS_Image = c.String(),
                        Phone_Image = c.String(),
                        Phone_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.Phones", t => t.Phone_Name)
                .Index(t => t.Phone_Name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Phone_Name", "dbo.Phones");
            DropIndex("dbo.Phones", new[] { "Phone_Name" });
            DropTable("dbo.Phones");
        }
    }
}

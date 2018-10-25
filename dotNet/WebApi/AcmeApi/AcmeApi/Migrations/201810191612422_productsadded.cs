namespace AcmeApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productsadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCode = c.String(),
                        ReleaseDate = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        StarRating = c.Double(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}

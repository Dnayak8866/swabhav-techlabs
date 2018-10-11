namespace MvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactMigrated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lname = c.String(),
                        contactNo = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.contacts");
        }
    }
}

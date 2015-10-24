namespace WebApplication.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        Content = c.String(),
                        Title = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Nickname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Title = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.Comments", "Author_Id", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropIndex("dbo.Comments", new[] { "Author_Id" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
        }
    }
}

namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOneToOne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "Cover_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Cover_Id");
            AddForeignKey("dbo.Courses", "Cover_Id", "dbo.Covers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Cover_Id", "dbo.Covers");
            DropIndex("dbo.Courses", new[] { "Cover_Id" });
            DropColumn("dbo.Courses", "Cover_Id");
            DropTable("dbo.Covers");
        }
    }
}

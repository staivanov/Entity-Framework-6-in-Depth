namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ManyToManyFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Cover_Id", "dbo.Covers");
            DropIndex("dbo.Courses", new[] { "Cover_Id" });
            DropColumn("dbo.Covers", "Id");
            RenameColumn(table: "dbo.Covers", name: "Cover_Id", newName: "Id");
            DropPrimaryKey("dbo.Covers");
            AlterColumn("dbo.Covers", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Covers", "Id");
            CreateIndex("dbo.Covers", "Id");
            DropColumn("dbo.Courses", "Cover_Id");
        }

        public override void Down()
        {
            AddColumn("dbo.Courses", "Cover_Id", c => c.Int());
            DropIndex("dbo.Covers", new[] { "Id" });
            DropPrimaryKey("dbo.Covers");
            AlterColumn("dbo.Covers", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Covers", "Id");
            RenameColumn(table: "dbo.Covers", name: "Id", newName: "Cover_Id");
            AddColumn("dbo.Covers", "Id", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Courses", "Cover_Id");
            AddForeignKey("dbo.Courses", "Cover_Id", "dbo.Covers", "Id");
        }
    }
}

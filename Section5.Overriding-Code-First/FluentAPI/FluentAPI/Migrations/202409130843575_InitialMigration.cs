namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "CourseTags");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "AuthorId");
            DropPrimaryKey("dbo.CourseTags");
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.CourseTags", new[] { "Course_Id", "Tag_Id" });
            CreateIndex("dbo.Courses", "AuthorId");
        }

        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            DropPrimaryKey("dbo.CourseTags");
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int());
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            AddPrimaryKey("dbo.CourseTags", new[] { "Tag_Id", "Course_Id" });
            RenameColumn(table: "dbo.Courses", name: "AuthorId", newName: "Author_Id");
            CreateIndex("dbo.Courses", "Author_Id");
            RenameTable(name: "dbo.CourseTags", newName: "TagCourses");
        }
    }
}

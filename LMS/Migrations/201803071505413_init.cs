namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Modules", "CourseId_Id", "dbo.Courses");
            DropIndex("dbo.Modules", new[] { "CourseId_Id" });
            AddColumn("dbo.Courses", "Module_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Module_Id");
            AddForeignKey("dbo.Courses", "Module_Id", "dbo.Modules", "Id");
            DropColumn("dbo.Modules", "CourseId_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modules", "CourseId_Id", c => c.Int());
            DropForeignKey("dbo.Courses", "Module_Id", "dbo.Modules");
            DropIndex("dbo.Courses", new[] { "Module_Id" });
            DropColumn("dbo.Courses", "Module_Id");
            CreateIndex("dbo.Modules", "CourseId_Id");
            AddForeignKey("dbo.Modules", "CourseId_Id", "dbo.Courses", "Id");
        }
    }
}

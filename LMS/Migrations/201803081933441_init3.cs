namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Modules", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Activities", "ModuleId", "dbo.Modules");
            DropForeignKey("dbo.Activities", "ActivityType_ActivityTypeId", "dbo.ActivityTypes");
            DropForeignKey("dbo.AspNetUsers", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.Activities", new[] { "ModuleId" });
            DropIndex("dbo.Modules", new[] { "CourseId" });
            RenameColumn(table: "dbo.Activities", name: "ActivityType_ActivityTypeId", newName: "ActivityType_Id");
            RenameColumn(table: "dbo.Modules", name: "CourseId", newName: "Course_Id");
            RenameColumn(table: "dbo.AspNetUsers", name: "Course_CourseId", newName: "Course_Id");
            RenameColumn(table: "dbo.Activities", name: "ModuleId", newName: "Module_Id");
            RenameIndex(table: "dbo.Activities", name: "IX_ActivityType_ActivityTypeId", newName: "IX_ActivityType_Id");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_Course_CourseId", newName: "IX_Course_Id");
            DropPrimaryKey("dbo.Activities");
            DropPrimaryKey("dbo.ActivityTypes");
            DropPrimaryKey("dbo.Modules");
            DropPrimaryKey("dbo.Courses");
            AddColumn("dbo.Activities", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.ActivityTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Modules", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Activities", "ActivityName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Activities", "Description", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Activities", "Module_Id", c => c.Int());
            AlterColumn("dbo.Modules", "Course_Id", c => c.Int());
            AddPrimaryKey("dbo.Activities", "Id");
            AddPrimaryKey("dbo.ActivityTypes", "Id");
            AddPrimaryKey("dbo.Modules", "Id");
            AddPrimaryKey("dbo.Courses", "Id");
            CreateIndex("dbo.Activities", "Module_Id");
            CreateIndex("dbo.Modules", "Course_Id");
            AddForeignKey("dbo.Modules", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Activities", "Module_Id", "dbo.Modules", "Id");
            AddForeignKey("dbo.Activities", "ActivityType_Id", "dbo.ActivityTypes", "Id");
            AddForeignKey("dbo.AspNetUsers", "Course_Id", "dbo.Courses", "Id");
            DropColumn("dbo.Activities", "ActivityId");
            DropColumn("dbo.ActivityTypes", "ActivityTypeId");
            DropColumn("dbo.Modules", "ModuleId");
            DropColumn("dbo.Courses", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Modules", "ModuleId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.ActivityTypes", "ActivityTypeId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Activities", "ActivityId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.AspNetUsers", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Activities", "ActivityType_Id", "dbo.ActivityTypes");
            DropForeignKey("dbo.Activities", "Module_Id", "dbo.Modules");
            DropForeignKey("dbo.Modules", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Modules", new[] { "Course_Id" });
            DropIndex("dbo.Activities", new[] { "Module_Id" });
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Modules");
            DropPrimaryKey("dbo.ActivityTypes");
            DropPrimaryKey("dbo.Activities");
            AlterColumn("dbo.Modules", "Course_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "Module_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "Description", c => c.String(maxLength: 200));
            AlterColumn("dbo.Activities", "ActivityName", c => c.String(nullable: false));
            DropColumn("dbo.Courses", "Id");
            DropColumn("dbo.Modules", "Id");
            DropColumn("dbo.ActivityTypes", "Id");
            DropColumn("dbo.Activities", "Id");
            AddPrimaryKey("dbo.Courses", "CourseId");
            AddPrimaryKey("dbo.Modules", "ModuleId");
            AddPrimaryKey("dbo.ActivityTypes", "ActivityTypeId");
            AddPrimaryKey("dbo.Activities", "ActivityId");
            RenameIndex(table: "dbo.AspNetUsers", name: "IX_Course_Id", newName: "IX_Course_CourseId");
            RenameIndex(table: "dbo.Activities", name: "IX_ActivityType_Id", newName: "IX_ActivityType_ActivityTypeId");
            RenameColumn(table: "dbo.Activities", name: "Module_Id", newName: "ModuleId");
            RenameColumn(table: "dbo.AspNetUsers", name: "Course_Id", newName: "Course_CourseId");
            RenameColumn(table: "dbo.Modules", name: "Course_Id", newName: "CourseId");
            RenameColumn(table: "dbo.Activities", name: "ActivityType_Id", newName: "ActivityType_ActivityTypeId");
            CreateIndex("dbo.Modules", "CourseId");
            CreateIndex("dbo.Activities", "ModuleId");
            AddForeignKey("dbo.AspNetUsers", "Course_CourseId", "dbo.Courses", "CourseId");
            AddForeignKey("dbo.Activities", "ActivityType_ActivityTypeId", "dbo.ActivityTypes", "ActivityTypeId");
            AddForeignKey("dbo.Activities", "ModuleId", "dbo.Modules", "ModuleId", cascadeDelete: true);
            AddForeignKey("dbo.Modules", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
        }
    }
}

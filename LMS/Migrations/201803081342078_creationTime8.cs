namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creationTime8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Module_Id", "dbo.Modules");
            DropForeignKey("dbo.Activities", "Module_Id", "dbo.Modules");
            DropPrimaryKey("dbo.Modules");
            AlterColumn("dbo.Modules", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Modules", "Created", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Modules", "Id");
            AddForeignKey("dbo.Courses", "Module_Id", "dbo.Modules", "Id");
            AddForeignKey("dbo.Activities", "Module_Id", "dbo.Modules", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "Module_Id", "dbo.Modules");
            DropForeignKey("dbo.Courses", "Module_Id", "dbo.Modules");
            DropPrimaryKey("dbo.Modules");
            AlterColumn("dbo.Modules", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Modules", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Modules", "Id");
            AddForeignKey("dbo.Activities", "Module_Id", "dbo.Modules", "Id");
            AddForeignKey("dbo.Courses", "Module_Id", "dbo.Modules", "Id");
        }
    }
}

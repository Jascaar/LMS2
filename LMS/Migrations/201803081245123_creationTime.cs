namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creationTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modules", "CreationTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Modules", "CreationTime");
        }
    }
}

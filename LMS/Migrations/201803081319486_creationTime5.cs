namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creationTime5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Modules", "CreationTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modules", "CreationTime", c => c.DateTime(nullable: false));
        }
    }
}

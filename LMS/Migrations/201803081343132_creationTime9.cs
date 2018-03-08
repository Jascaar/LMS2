namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creationTime9 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Modules", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modules", "Created", c => c.DateTime(nullable: false));
        }
    }
}

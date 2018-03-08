namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creationTime10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Modules", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Modules", "Created");
        }
    }
}

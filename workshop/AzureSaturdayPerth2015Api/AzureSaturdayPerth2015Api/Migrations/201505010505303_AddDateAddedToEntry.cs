namespace AzureSaturdayPerth2015Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAddedToEntry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entry", "DateAdded", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Entry", "DateAdded");
        }
    }
}

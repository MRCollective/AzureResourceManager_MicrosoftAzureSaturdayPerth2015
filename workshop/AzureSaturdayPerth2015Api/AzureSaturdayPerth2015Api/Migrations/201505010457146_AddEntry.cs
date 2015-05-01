using System.Data.Entity.Migrations;

namespace AzureSaturdayPerth2015Api.Migrations
{
    public partial class AddEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entry",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entry");
        }
    }
}

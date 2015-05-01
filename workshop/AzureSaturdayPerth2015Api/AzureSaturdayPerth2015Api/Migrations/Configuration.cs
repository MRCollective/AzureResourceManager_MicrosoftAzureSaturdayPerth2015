using System.Data.Entity.Migrations;
using AzureSaturdayPerth2015Api.Infrastructure.Database;

namespace AzureSaturdayPerth2015Api.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
        }
    }
}

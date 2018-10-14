using Microsoft.EntityFrameworkCore.Migrations;

namespace RentMyStuff.Data.Migrations
{
    public partial class PopulateAssetTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AssetTypes (Id, Name) VALUES (1, 'Movie')");
            migrationBuilder.Sql("INSERT INTO AssetTypes (Id, Name) VALUES (2, 'Book')");
            migrationBuilder.Sql("INSERT INTO AssetTypes (Id, Name) VALUES (3, 'Tool')");
            migrationBuilder.Sql("INSERT INTO AssetTypes (Id, Name) VALUES (4, 'Power Tool')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace carDealer.Migrations
{
    public partial class SeedDatabse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Makes\" (\"Name\")VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO \"Makes\" (\"Name\")VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO \"Makes\" (\"Name\")VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\",\"MakeId\")VALUES ('Make1-ModelA',25)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make1-ModelB',25)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make1-ModelC',25)");

            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make2-ModelA',26)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make2-ModelB',26)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make2-ModelC',26)");

            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make3-ModelA',27)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make3-ModelB',27)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make3-ModelC',27)");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Makes\" WHERE \"Name\" IN ('Make1','Make2',Make3')");
        }
    }
}

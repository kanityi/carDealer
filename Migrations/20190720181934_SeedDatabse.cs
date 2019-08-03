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

            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\",\"MakeId\")VALUES ('Make1-ModelA',28)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make1-ModelB',28)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make1-ModelC',28)");

            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make2-ModelA',29)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make2-ModelB',29)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make2-ModelC',29)");

            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make3-ModelA',30)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make3-ModelB',30)");
            migrationBuilder.Sql("INSERT INTO \"Models\" (\"Name\", \"MakeId\")VALUES ('Make3-ModelC',30)");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Makes\" WHERE \"Name\" IN ('Make1','Make2',Make3')");
        }
    }
}

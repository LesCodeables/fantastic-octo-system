using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetcore.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes VALUES('MAKE1')");
            migrationBuilder.Sql("INSERT INTO Makes VALUES('MAKE2')");
            migrationBuilder.Sql("INSERT INTO Makes VALUES('MAKE3')");

            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE1-MODELA',(SELECT Id FROM Makes WHERE Name='MAKE1'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE1-MODELB',(SELECT Id FROM Makes WHERE Name='MAKE1'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE1-MODELC',(SELECT Id FROM Makes WHERE Name='MAKE1'))");

            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE2-MODELA',(SELECT Id FROM Makes WHERE Name='MAKE2'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE2-MODELB',(SELECT Id FROM Makes WHERE Name='MAKE2'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE2-MODELC',(SELECT Id FROM Makes WHERE Name='MAKE2'))");

            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE3-MODELA',(SELECT Id FROM Makes WHERE Name='MAKE3'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE3-MODELB',(SELECT Id FROM Makes WHERE Name='MAKE3'))");
            migrationBuilder.Sql("INSERT INTO Models VALUES('MAKE3-MODELC',(SELECT Id FROM Makes WHERE Name='MAKE3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN 'MAKE1', 'MAKE2', 'MAKE3'");
        }
    }
}

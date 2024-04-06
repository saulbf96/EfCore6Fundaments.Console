using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore6Fundaments.Data.Migrations
{
    public partial class CoverOnlynotFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Covers",
                columns: new[] { "CoverId", "DesignIdeas", "DigitalOnly" },
                values: new object[] { 1, "Hola a todo el futbol", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 1);
        }
    }
}

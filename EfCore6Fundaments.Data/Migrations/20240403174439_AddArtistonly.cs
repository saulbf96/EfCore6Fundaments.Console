using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore6Fundaments.Data.Migrations
{
    public partial class AddArtistonly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "FirstName", "LastName" },
                values: new object[] { 1, "Pausini", "Pique" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);
        }
    }
}

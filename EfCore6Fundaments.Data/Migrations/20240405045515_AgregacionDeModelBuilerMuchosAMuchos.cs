using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore6Fundaments.Data.Migrations
{
    public partial class AgregacionDeModelBuilerMuchosAMuchos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistCover_Artists_ArtistsArtistId",
                table: "ArtistCover");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistCover_Covers_CoversCoverId",
                table: "ArtistCover");

            migrationBuilder.RenameColumn(
                name: "CoversCoverId",
                table: "ArtistCover",
                newName: "CoverId");

            migrationBuilder.RenameColumn(
                name: "ArtistsArtistId",
                table: "ArtistCover",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtistCover_CoversCoverId",
                table: "ArtistCover",
                newName: "IX_ArtistCover_CoverId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistCover_Artists_ArtistId",
                table: "ArtistCover",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistCover_Covers_CoverId",
                table: "ArtistCover",
                column: "CoverId",
                principalTable: "Covers",
                principalColumn: "CoverId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistCover_Artists_ArtistId",
                table: "ArtistCover");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistCover_Covers_CoverId",
                table: "ArtistCover");

            migrationBuilder.RenameColumn(
                name: "CoverId",
                table: "ArtistCover",
                newName: "CoversCoverId");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "ArtistCover",
                newName: "ArtistsArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_ArtistCover_CoverId",
                table: "ArtistCover",
                newName: "IX_ArtistCover_CoversCoverId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistCover_Artists_ArtistsArtistId",
                table: "ArtistCover",
                column: "ArtistsArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistCover_Covers_CoversCoverId",
                table: "ArtistCover",
                column: "CoversCoverId",
                principalTable: "Covers",
                principalColumn: "CoverId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

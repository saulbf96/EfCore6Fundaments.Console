using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore6Fundaments.Data.Migrations
{
    public partial class BookAnCoverOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Covers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Pablo", "Picasso" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, "Dee", "Bell" },
                    { 3, "Katharine", "Kuharic" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Rhoda", "Lerman" },
                    { 2, "Ruth", "Ozeki" },
                    { 3, "Sofia", "Segovia" },
                    { 4, "Ursula K.", "LeGuin" },
                    { 5, "Hugh", "Howey" },
                    { 6, "Isabelle", "Allende" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 1, 1, 0m, new DateTime(1989, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In God's Ear" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 2, 2, 0m, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Tale For the Time Being" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 3, 3, 0m, new DateTime(1969, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Left Hand of Darkness" });

            migrationBuilder.UpdateData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 1,
                columns: new[] { "BookId", "DesignIdeas", "DigitalOnly" },
                values: new object[] { 3, "How about a left hand in the dark?", false });

            migrationBuilder.InsertData(
                table: "Covers",
                columns: new[] { "CoverId", "BookId", "DesignIdeas", "DigitalOnly" },
                values: new object[] { 2, 2, "Should we put a clock?", true });

            migrationBuilder.InsertData(
                table: "Covers",
                columns: new[] { "CoverId", "BookId", "DesignIdeas", "DigitalOnly" },
                values: new object[] { 3, 1, "A big ear in the clouds?", false });

            migrationBuilder.CreateIndex(
                name: "IX_Covers_BookId",
                table: "Covers",
                column: "BookId",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Covers_Books_BookId",
                table: "Covers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistCover_Artists_ArtistsArtistId",
                table: "ArtistCover");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistCover_Covers_CoversCoverId",
                table: "ArtistCover");

            migrationBuilder.DropForeignKey(
                name: "FK_Covers_Books_BookId",
                table: "Covers");

            migrationBuilder.DropIndex(
                name: "IX_Covers_BookId",
                table: "Covers");

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Covers");

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

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Pausini", "Pique" });

            migrationBuilder.UpdateData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 1,
                columns: new[] { "DesignIdeas", "DigitalOnly" },
                values: new object[] { "Hola a todo el futbol", true });

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
    }
}

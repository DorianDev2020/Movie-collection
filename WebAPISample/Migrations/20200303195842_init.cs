using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPISample.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeadRole",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupportingRole",
                table: "Movies",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Director", "Genre", "LeadRole", "SupportingRole", "Title" },
                values: new object[,]
                {
                    { 1, "Martin Scorsese", "Drama", null, null, "The Departed" },
                    { 2, "Christopher Nolan", "Drama", null, null, "The Dark Knight" },
                    { 3, "Christopher Nolan", "Drama", null, null, "Inception" },
                    { 4, "David Gordon Green", "Comedy", null, null, "Pineapple Express" },
                    { 5, "John McTiernan", "Action", null, null, "Die Hard" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "LeadRole",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "SupportingRole",
                table: "Movies");
        }
    }
}

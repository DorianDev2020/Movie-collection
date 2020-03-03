using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPISample.Migrations
{
    public partial class updatingTableparams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { "Leonardo DiCaprio", "Jack Nicholson" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { "Christian Bale", "Heath Ledger" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "LeadRole",
                value: "Leonardo DiCaprio");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { "Seth Rogan", "James Franco" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { "Bruce Willice", "Bonnie Bedelia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "LeadRole",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "LeadRole", "SupportingRole" },
                values: new object[] { null, null });
        }
    }
}

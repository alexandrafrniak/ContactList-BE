using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace callList.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "elena@siva.sk", "Elena", "Siva", "+421905342347" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2, "elena@siva.sk", "Elena", "Siva", "+421905342347" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 3, "elena@siva.sk", "Elena", "Siva", "+421905342347" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 4, "elena@siva.sk", "Elena", "Siva", "+421905342347" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 5, "elena@siva.sk", "Elena", "Siva", "+421905342347" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 6, "elena@siva.sk", "Elena", "Siva", "+421905342347" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}

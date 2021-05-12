using Microsoft.EntityFrameworkCore.Migrations;

namespace solutionthree.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(type: "TEXT", nullable: true),
                    lastName = table.Column<string>(type: "TEXT", nullable: true),
                    age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "person",
                columns: new[] { "id", "age", "firstName", "lastName" },
                values: new object[] { 1, 27, "Joe", "Soap" });

            migrationBuilder.InsertData(
                table: "person",
                columns: new[] { "id", "age", "firstName", "lastName" },
                values: new object[] { 2, 35, "Daniel", "Moshe" });

            migrationBuilder.InsertData(
                table: "person",
                columns: new[] { "id", "age", "firstName", "lastName" },
                values: new object[] { 3, 29, "Seth", "Smith" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "person");
        }
    }
}

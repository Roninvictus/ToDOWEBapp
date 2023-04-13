using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo.Migrations
{
    public partial class ToDomigrationcreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Completed", "Description", "Title" },
                values: new object[] { 1, true, "Finish Web assignment", "ToDo assignment" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Completed", "Description", "Title" },
                values: new object[] { 2, false, "Finish ios assignment", "ios assignment" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Completed", "Description", "Title" },
                values: new object[] { 3, false, "Finish kotlin assignment", "kotlin assignment" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Completed", "Description", "Title" },
                values: new object[] { 4, true, "Finish DBA assignment", "DBA assignment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}

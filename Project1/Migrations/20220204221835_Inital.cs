using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Quadrant = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskID);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 1, "School", true, new DateTime(2022, 2, 4, 22, 18, 35, 376, DateTimeKind.Utc).AddTicks(8990), 1, "Make the database" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 2, "Home", false, new DateTime(2022, 2, 4, 22, 18, 35, 377, DateTimeKind.Utc).AddTicks(440), 2, "Make the Shared Layout" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 3, "Work", false, new DateTime(2022, 2, 4, 22, 18, 35, 377, DateTimeKind.Utc).AddTicks(460), 3, "Make the quadrant views" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "Category", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 4, "Church", false, new DateTime(2022, 2, 4, 22, 18, 35, 377, DateTimeKind.Utc).AddTicks(460), 4, "Make the Controllers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Quadrant = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Tasks_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "School" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Home" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "CategoryID", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 1, 1, true, new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(3080), 1, "Make the database" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "CategoryID", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 4, 2, false, new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(4250), 4, "Make the Controllers" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "CategoryID", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 2, 3, false, new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(4220), 2, "Make the Shared Layout" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "CategoryID", "Completed", "Date", "Quadrant", "Task" },
                values: new object[] { 3, 4, false, new DateTime(2022, 2, 4, 22, 39, 38, 855, DateTimeKind.Utc).AddTicks(4250), 3, "Make the quadrant views" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryID",
                table: "Tasks",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

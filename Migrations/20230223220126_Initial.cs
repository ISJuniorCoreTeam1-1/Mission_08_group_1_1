using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_08_group_1_1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catergories",
                columns: table => new
                {
                    CatergoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatergoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catergories", x => x.CatergoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Quadrant = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Tasks_Catergories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catergories",
                        principalColumn: "CatergoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 1, 1, false, new DateTime(2023, 2, 23, 15, 1, 25, 714, DateTimeKind.Local).AddTicks(7189), 1, "Crisis" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 2, 1, false, new DateTime(2023, 2, 23, 15, 1, 25, 718, DateTimeKind.Local).AddTicks(5316), 2, "Recreation" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 3, 3, false, new DateTime(2023, 2, 23, 15, 1, 25, 718, DateTimeKind.Local).AddTicks(5412), 3, "Interruptions" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 4, 3, false, new DateTime(2023, 2, 23, 15, 1, 25, 718, DateTimeKind.Local).AddTicks(5420), 4, "Time Wasters" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryId",
                table: "Tasks",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Catergories");
        }
    }
}

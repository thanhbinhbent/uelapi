using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UELStudents.Migrations
{
    /// <inheritdoc />
    public partial class DBEditTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EndYear",
                table: "TestSchedule",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "TestSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartYear",
                table: "TestSchedule",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndYear",
                table: "TestSchedule");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "TestSchedule");

            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "TestSchedule");
        }
    }
}

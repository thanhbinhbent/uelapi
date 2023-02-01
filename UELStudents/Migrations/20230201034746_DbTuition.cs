using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UELStudents.Migrations
{
    /// <inheritdoc />
    public partial class DbTuition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "TuitionType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                table: "TuitionType");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UELStudents.Migrations
{
    /// <inheritdoc />
    public partial class AdđbActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scores_Students_StudentId",
                table: "Scores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scores",
                table: "Scores");

            migrationBuilder.RenameTable(
                name: "Scores",
                newName: "ActivityScore");

            migrationBuilder.RenameIndex(
                name: "IX_Scores_StudentId",
                table: "ActivityScore",
                newName: "IX_ActivityScore_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivityScore",
                table: "ActivityScore",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityScore_Students_StudentId",
                table: "ActivityScore",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityScore_Students_StudentId",
                table: "ActivityScore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivityScore",
                table: "ActivityScore");

            migrationBuilder.RenameTable(
                name: "ActivityScore",
                newName: "Scores");

            migrationBuilder.RenameIndex(
                name: "IX_ActivityScore_StudentId",
                table: "Scores",
                newName: "IX_Scores_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scores",
                table: "Scores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Students_StudentId",
                table: "Scores",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

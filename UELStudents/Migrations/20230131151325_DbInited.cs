using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UELStudents.Migrations
{
    /// <inheritdoc />
    public partial class DbInited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Dob = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelfEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelfPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearAdmission = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Faculity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TuitionType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TuitionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    StartYear = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    EndYear = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuitionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Attendence = table.Column<float>(type: "real", nullable: false),
                    Midterm = table.Column<float>(type: "real", nullable: false),
                    Final = table.Column<float>(type: "real", nullable: false),
                    Advanced = table.Column<float>(type: "real", nullable: false),
                    PercentAttendence = table.Column<double>(type: "float", nullable: false),
                    PercentMidterm = table.Column<double>(type: "float", nullable: false),
                    PercentFinal = table.Column<double>(type: "float", nullable: false),
                    PercentAdvanced = table.Column<double>(type: "float", nullable: false),
                    StartYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    EndYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Score_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Score_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestSchedule",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Time = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestSchedule_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSchedule_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursesLine",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartYear = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    EndYear = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesLine_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesLine_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesLine_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Datetime = table.Column<DateTime>(type: "datetime2", maxLength: 15, nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Room = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TimeStart = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TimeEnd = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TimeFormat = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedule_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedule_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tuition",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TuitionId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AmountPaid = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tuition_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tuition_TuitionType_TuitionId",
                        column: x => x.TuitionId,
                        principalTable: "TuitionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursesLine_CourseId",
                table: "CoursesLine",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesLine_StudentId",
                table: "CoursesLine",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesLine_TeacherId",
                table: "CoursesLine",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_CourseId",
                table: "Schedule",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_StudentId",
                table: "Schedule",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_TeacherId",
                table: "Schedule",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_CourseId",
                table: "Score",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_StudentId",
                table: "Score",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSchedule_CourseId",
                table: "TestSchedule",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSchedule_StudentId",
                table: "TestSchedule",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tuition_StudentId",
                table: "Tuition",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tuition_TuitionId",
                table: "Tuition",
                column: "TuitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesLine");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "TestSchedule");

            migrationBuilder.DropTable(
                name: "Tuition");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TuitionType");
        }
    }
}

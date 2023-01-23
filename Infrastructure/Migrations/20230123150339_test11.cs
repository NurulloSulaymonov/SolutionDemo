using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classroom_Teachers_TeacherId",
                table: "Classroom");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Classroom_ClassroomId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ClassroomId",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "Subject");

            migrationBuilder.RenameTable(
                name: "Classroom",
                newName: "Classrooms");

            migrationBuilder.RenameIndex(
                name: "IX_Classroom_TeacherId",
                table: "Classrooms",
                newName: "IX_Classrooms_TeacherId");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Classrooms",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ClassroomStudents",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    ClassroomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomStudents", x => new { x.StudentId, x.ClassroomId });
                    table.ForeignKey(
                        name: "FK_ClassroomStudents_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassroomStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayOfWeek = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StartTime = table.Column<string>(type: "text", nullable: false),
                    EndTime = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTimetable",
                columns: table => new
                {
                    TimetableId = table.Column<int>(type: "integer", nullable: false),
                    ClassroomId = table.Column<int>(type: "integer", nullable: false),
                    SubjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTimetable", x => new { x.ClassroomId, x.TimetableId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_SubjectTimetable_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTimetable_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTimetable_TimeTable_TimetableId",
                        column: x => x.TimetableId,
                        principalTable: "TimeTable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassroomStudents_ClassroomId",
                table: "ClassroomStudents",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTimetable_SubjectId",
                table: "SubjectTimetable",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTimetable_TimetableId",
                table: "SubjectTimetable",
                column: "TimetableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Teachers_TeacherId",
                table: "Classrooms",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Teachers_TeacherId",
                table: "Classrooms");

            migrationBuilder.DropTable(
                name: "ClassroomStudents");

            migrationBuilder.DropTable(
                name: "SubjectTimetable");

            migrationBuilder.DropTable(
                name: "TimeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms");

            migrationBuilder.RenameTable(
                name: "Classrooms",
                newName: "Classroom");

            migrationBuilder.RenameIndex(
                name: "IX_Classrooms_TeacherId",
                table: "Classroom",
                newName: "IX_Classroom_TeacherId");

            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "Subject",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "Classroom",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ClassroomId",
                table: "Subject",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classroom_Teachers_TeacherId",
                table: "Classroom",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Classroom_ClassroomId",
                table: "Subject",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTimetable_Classrooms_ClassroomId",
                table: "SubjectTimetable");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTimetable_Subject_SubjectId",
                table: "SubjectTimetable");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTimetable_TimeTable_TimetableId",
                table: "SubjectTimetable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeTable",
                table: "TimeTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectTimetable",
                table: "SubjectTimetable");

            migrationBuilder.RenameTable(
                name: "TimeTable",
                newName: "TimeTables");

            migrationBuilder.RenameTable(
                name: "SubjectTimetable",
                newName: "SubjectTimetables");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectTimetable_TimetableId",
                table: "SubjectTimetables",
                newName: "IX_SubjectTimetables_TimetableId");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectTimetable_SubjectId",
                table: "SubjectTimetables",
                newName: "IX_SubjectTimetables_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeTables",
                table: "TimeTables",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectTimetables",
                table: "SubjectTimetables",
                columns: new[] { "ClassroomId", "TimetableId", "SubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTimetables_Classrooms_ClassroomId",
                table: "SubjectTimetables",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTimetables_Subject_SubjectId",
                table: "SubjectTimetables",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTimetables_TimeTables_TimetableId",
                table: "SubjectTimetables",
                column: "TimetableId",
                principalTable: "TimeTables",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTimetables_Classrooms_ClassroomId",
                table: "SubjectTimetables");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTimetables_Subject_SubjectId",
                table: "SubjectTimetables");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectTimetables_TimeTables_TimetableId",
                table: "SubjectTimetables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeTables",
                table: "TimeTables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectTimetables",
                table: "SubjectTimetables");

            migrationBuilder.RenameTable(
                name: "TimeTables",
                newName: "TimeTable");

            migrationBuilder.RenameTable(
                name: "SubjectTimetables",
                newName: "SubjectTimetable");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectTimetables_TimetableId",
                table: "SubjectTimetable",
                newName: "IX_SubjectTimetable_TimetableId");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectTimetables_SubjectId",
                table: "SubjectTimetable",
                newName: "IX_SubjectTimetable_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeTable",
                table: "TimeTable",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectTimetable",
                table: "SubjectTimetable",
                columns: new[] { "ClassroomId", "TimetableId", "SubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTimetable_Classrooms_ClassroomId",
                table: "SubjectTimetable",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTimetable_Subject_SubjectId",
                table: "SubjectTimetable",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectTimetable_TimeTable_TimetableId",
                table: "SubjectTimetable",
                column: "TimetableId",
                principalTable: "TimeTable",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class refactored : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Exams_StudentExamId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Subject_SubjectId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Subject_SubjectId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SubjectId",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_SubjectId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "StudentExamId",
                table: "Results");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Results",
                newName: "ExamId");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Exams",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                columns: new[] { "ExamId", "StudentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subject_SubjectId",
                table: "Exams",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subject_SubjectId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SubjectId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "Results",
                newName: "SubjectId");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Subject",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentExamId",
                table: "Results",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                column: "StudentExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectId",
                table: "Subject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_SubjectId",
                table: "Results",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Exams_StudentExamId",
                table: "Results",
                column: "StudentExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Subject_SubjectId",
                table: "Results",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Subject_SubjectId",
                table: "Subject",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id");
        }
    }
}

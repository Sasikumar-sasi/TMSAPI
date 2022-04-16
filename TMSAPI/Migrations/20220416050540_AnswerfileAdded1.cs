using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class AnswerfileAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "answers",
                columns: table => new
                {
                    AnswerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentID = table.Column<int>(type: "int", nullable: false),
                    TraineeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answers", x => x.AnswerID);
                    table.ForeignKey(
                        name: "FK_answers_assessments_AssessmentID",
                        column: x => x.AssessmentID,
                        principalTable: "assessments",
                        principalColumn: "AssessmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_answers_trainees_TraineeID",
                        column: x => x.TraineeID,
                        principalTable: "trainees",
                        principalColumn: "TraineeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_answers_AssessmentID",
                table: "answers",
                column: "AssessmentID");

            migrationBuilder.CreateIndex(
                name: "IX_answers_TraineeID",
                table: "answers",
                column: "TraineeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "answers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class ScoreFileCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentID = table.Column<int>(type: "int", nullable: false),
                    TraineeID = table.Column<int>(type: "int", nullable: false),
                    GainedScore = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Score");
        }
    }
}

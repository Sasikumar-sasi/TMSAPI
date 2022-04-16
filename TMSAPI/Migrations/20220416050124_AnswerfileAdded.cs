using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class AnswerfileAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainees_batch_BatchID",
                table: "trainees");

            migrationBuilder.DropIndex(
                name: "IX_trainees_BatchID",
                table: "trainees");

            migrationBuilder.DropColumn(
                name: "BatchID",
                table: "trainees");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "assessments");

            migrationBuilder.AddColumn<int>(
                name: "TraineeID",
                table: "batch",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TraineeID",
                table: "batch");

            migrationBuilder.AddColumn<int>(
                name: "BatchID",
                table: "trainees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "assessments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_trainees_BatchID",
                table: "trainees",
                column: "BatchID");

            migrationBuilder.AddForeignKey(
                name: "FK_trainees_batch_BatchID",
                table: "trainees",
                column: "BatchID",
                principalTable: "batch",
                principalColumn: "BatchID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class TraineeUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BatchID",
                table: "trainees",
                type: "int",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

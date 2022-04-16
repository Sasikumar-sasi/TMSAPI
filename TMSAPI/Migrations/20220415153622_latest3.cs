using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class latest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainers_batch_BatchID",
                table: "trainers");

            migrationBuilder.DropIndex(
                name: "IX_trainers_BatchID",
                table: "trainers");

            migrationBuilder.DropColumn(
                name: "BatchID",
                table: "trainers");

            migrationBuilder.AddColumn<int>(
                name: "TrainerID",
                table: "batch",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_batch_TrainerID",
                table: "batch",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_batch_trainers_TrainerID",
                table: "batch",
                column: "TrainerID",
                principalTable: "trainers",
                principalColumn: "TrainerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_batch_trainers_TrainerID",
                table: "batch");

            migrationBuilder.DropIndex(
                name: "IX_batch_TrainerID",
                table: "batch");

            migrationBuilder.DropColumn(
                name: "TrainerID",
                table: "batch");

            migrationBuilder.AddColumn<int>(
                name: "BatchID",
                table: "trainers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_trainers_BatchID",
                table: "trainers",
                column: "BatchID",
                unique: true,
                filter: "[BatchID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_trainers_batch_BatchID",
                table: "trainers",
                column: "BatchID",
                principalTable: "batch",
                principalColumn: "BatchID");
        }
    }
}

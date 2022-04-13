using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class MigrationTableAltered : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_batch_TrainerID",
                table: "batch",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_batch_trainers_TrainerID",
                table: "batch",
                column: "TrainerID",
                principalTable: "trainers",
                principalColumn: "TrainerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_batch_trainers_TrainerID",
                table: "batch");

            migrationBuilder.DropIndex(
                name: "IX_batch_TrainerID",
                table: "batch");
        }
    }
}

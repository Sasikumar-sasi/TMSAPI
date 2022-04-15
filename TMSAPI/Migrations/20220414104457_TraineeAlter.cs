using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class TraineeAlter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainees_batch_BatchID",
                table: "trainees");

            migrationBuilder.AlterColumn<int>(
                name: "BatchID",
                table: "trainees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "BatchID",
                table: "trainees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_trainees_batch_BatchID",
                table: "trainees",
                column: "BatchID",
                principalTable: "batch",
                principalColumn: "BatchID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

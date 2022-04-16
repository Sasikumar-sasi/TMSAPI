using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMSAPI.Migrations
{
    public partial class BatchUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TraineeID",
                table: "batch");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TraineeID",
                table: "batch",
                type: "int",
                nullable: true);
        }
    }
}

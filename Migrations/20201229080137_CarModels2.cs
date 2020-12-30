using Microsoft.EntityFrameworkCore.Migrations;

namespace CarSheets_ServiceAuto.Migrations
{
    public partial class CarModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModel_CarModel_CarModelID",
                table: "CarModel");

            migrationBuilder.DropIndex(
                name: "IX_CarModel_CarModelID",
                table: "CarModel");

            migrationBuilder.DropColumn(
                name: "CarModelID",
                table: "CarModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarModelID",
                table: "CarModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarModel_CarModelID",
                table: "CarModel",
                column: "CarModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModel_CarModel_CarModelID",
                table: "CarModel",
                column: "CarModelID",
                principalTable: "CarModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CarSheets_ServiceAuto.Migrations
{
    public partial class CarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "CarSheet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CarModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carModelName = table.Column<string>(nullable: true),
                    CarModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarModel_CarModel_CarModelID",
                        column: x => x.CarModelID,
                        principalTable: "CarModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarSheet_CarModelId",
                table: "CarSheet",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModel_CarModelID",
                table: "CarModel",
                column: "CarModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarSheet_CarModel_CarModelId",
                table: "CarSheet",
                column: "CarModelId",
                principalTable: "CarModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSheet_CarModel_CarModelId",
                table: "CarSheet");

            migrationBuilder.DropTable(
                name: "CarModel");

            migrationBuilder.DropIndex(
                name: "IX_CarSheet_CarModelId",
                table: "CarSheet");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "CarSheet");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CarSheets_ServiceAuto.Migrations
{
    public partial class CarSheet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarSheet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nrInmatriculare = table.Column<string>(nullable: true),
                    nrIdentificareTalon = table.Column<string>(nullable: true),
                    descriereDefectiuni = table.Column<string>(nullable: true),
                    totalPlata = table.Column<decimal>(nullable: false),
                    luniGarantie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSheet", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarSheet");
        }
    }
}

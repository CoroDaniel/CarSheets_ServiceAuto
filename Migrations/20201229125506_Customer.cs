using Microsoft.EntityFrameworkCore.Migrations;

namespace CarSheets_ServiceAuto.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CarSheet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<int>(nullable: false),
                    CustomerAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarSheet_CustomerId",
                table: "CarSheet",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarSheet_Customer_CustomerId",
                table: "CarSheet",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSheet_Customer_CustomerId",
                table: "CarSheet");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_CarSheet_CustomerId",
                table: "CarSheet");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CarSheet");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGIIApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_Contribuyente_ContribuyenteRncCedula",
                table: "Comprobantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contribuyente",
                table: "Contribuyente");

            migrationBuilder.RenameTable(
                name: "Contribuyente",
                newName: "Contribuyentes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contribuyentes",
                table: "Contribuyentes",
                column: "RncCedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_Contribuyentes_ContribuyenteRncCedula",
                table: "Comprobantes",
                column: "ContribuyenteRncCedula",
                principalTable: "Contribuyentes",
                principalColumn: "RncCedula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_Contribuyentes_ContribuyenteRncCedula",
                table: "Comprobantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contribuyentes",
                table: "Contribuyentes");

            migrationBuilder.RenameTable(
                name: "Contribuyentes",
                newName: "Contribuyente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contribuyente",
                table: "Contribuyente",
                column: "RncCedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_Contribuyente_ContribuyenteRncCedula",
                table: "Comprobantes",
                column: "ContribuyenteRncCedula",
                principalTable: "Contribuyente",
                principalColumn: "RncCedula");
        }
    }
}

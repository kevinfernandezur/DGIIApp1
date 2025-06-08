using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DGIIApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contribuyente",
                columns: table => new
                {
                    RncCedula = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Estatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuyente", x => x.RncCedula);
                });

            migrationBuilder.CreateTable(
                name: "Comprobantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RncCedula = table.Column<string>(type: "TEXT", nullable: false),
                    NCF = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<string>(type: "TEXT", nullable: false),
                    Itbis18 = table.Column<string>(type: "TEXT", nullable: false),
                    ContribuyenteRncCedula = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprobantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comprobantes_Contribuyente_ContribuyenteRncCedula",
                        column: x => x.ContribuyenteRncCedula,
                        principalTable: "Contribuyente",
                        principalColumn: "RncCedula");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_ContribuyenteRncCedula",
                table: "Comprobantes",
                column: "ContribuyenteRncCedula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comprobantes");

            migrationBuilder.DropTable(
                name: "Contribuyente");
        }
    }
}

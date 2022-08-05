using Microsoft.EntityFrameworkCore.Migrations;

namespace Automoviles.DataAccess.Migrations
{
    public partial class AgregadoFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CombustibleId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeguroId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ColorId",
                table: "Vehiculos",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_CombustibleId",
                table: "Vehiculos",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MarcaId",
                table: "Vehiculos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_PaisId",
                table: "Vehiculos",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_SeguroId",
                table: "Vehiculos",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoId",
                table: "Vehiculos",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Color_ColorId",
                table: "Vehiculos",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Combustible_CombustibleId",
                table: "Vehiculos",
                column: "CombustibleId",
                principalTable: "Combustible",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Marca_MarcaId",
                table: "Vehiculos",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Pais_PaisId",
                table: "Vehiculos",
                column: "PaisId",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Seguro_SeguroId",
                table: "Vehiculos",
                column: "SeguroId",
                principalTable: "Seguro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Tipo_TipoId",
                table: "Vehiculos",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Color_ColorId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Combustible_CombustibleId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Marca_MarcaId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Pais_PaisId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Seguro_SeguroId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Tipo_TipoId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ColorId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_CombustibleId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_MarcaId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_PaisId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_SeguroId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_TipoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "CombustibleId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "SeguroId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Vehiculos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutrInfo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissoes_Departamentos_DepartamentoID",
                table: "Permissoes");

            migrationBuilder.DropIndex(
                name: "IX_Permissoes_DepartamentoID",
                table: "Permissoes");

            migrationBuilder.DropColumn(
                name: "DepartamentoID",
                table: "Permissoes");

            migrationBuilder.AddColumn<int>(
                name: "PermissaoID",
                table: "Departamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_PermissaoID",
                table: "Departamentos",
                column: "PermissaoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Permissoes_PermissaoID",
                table: "Departamentos",
                column: "PermissaoID",
                principalTable: "Permissoes",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Permissoes_PermissaoID",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_PermissaoID",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "PermissaoID",
                table: "Departamentos");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoID",
                table: "Permissoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissoes_DepartamentoID",
                table: "Permissoes",
                column: "DepartamentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissoes_Departamentos_DepartamentoID",
                table: "Permissoes",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "ID");
        }
    }
}

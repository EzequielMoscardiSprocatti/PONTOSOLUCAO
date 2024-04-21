using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PONTO.DAO.Migrations
{
    /// <inheritdoc />
    public partial class TbClienteV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Clientes",
                newName: "CPF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Clientes",
                newName: "Cpf");
        }
    }
}

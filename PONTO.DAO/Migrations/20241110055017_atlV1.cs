using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PONTO.DAO.Migrations
{
    /// <inheritdoc />
    public partial class atlV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InfoAdicional",
                table: "disparosAcaos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InfoAdicional",
                table: "disparosAcaos");
        }
    }
}

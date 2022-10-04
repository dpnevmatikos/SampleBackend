using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleBackend.Migrations.Migrations
{
    public partial class AddVatNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VatNumber",
                table: "Customer",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VatNumber",
                table: "Customer");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_Semus.Migrations
{
    public partial class updateModelPharmacologicalGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "PharmacologicalGroups",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SectionName",
                table: "PharmacologicalGroups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section",
                table: "PharmacologicalGroups");

            migrationBuilder.DropColumn(
                name: "SectionName",
                table: "PharmacologicalGroups");
        }
    }
}

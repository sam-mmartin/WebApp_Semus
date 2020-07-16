using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_Semus.Migrations
{
    public partial class UpdateSchemaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicaments_PharmacologicalGroups_PharmacologicalGroupID",
                table: "Medicaments");

            migrationBuilder.DropTable(
                name: "PharmacologicalGroups");

            migrationBuilder.DropIndex(
                name: "IX_Medicaments_PharmacologicalGroupID",
                table: "Medicaments");

            migrationBuilder.DropColumn(
                name: "PharmacologicalGroupID",
                table: "Medicaments");

            migrationBuilder.AlterColumn<string>(
                name: "Availability",
                table: "Medicaments",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstSubGroup",
                table: "Medicaments",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PharmacologicalGroup",
                table: "Medicaments",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondSubGroup",
                table: "Medicaments",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Medicaments",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdSubGroup",
                table: "Medicaments",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstSubGroup",
                table: "Medicaments");

            migrationBuilder.DropColumn(
                name: "PharmacologicalGroup",
                table: "Medicaments");

            migrationBuilder.DropColumn(
                name: "SecondSubGroup",
                table: "Medicaments");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Medicaments");

            migrationBuilder.DropColumn(
                name: "ThirdSubGroup",
                table: "Medicaments");

            migrationBuilder.AlterColumn<string>(
                name: "Availability",
                table: "Medicaments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AddColumn<int>(
                name: "PharmacologicalGroupID",
                table: "Medicaments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PharmacologicalGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FirstSubGroup = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SecondGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SecondSubGroup = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Section = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ThirdSubGroup = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacologicalGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PharmacologicalGroups_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_PharmacologicalGroupID",
                table: "Medicaments",
                column: "PharmacologicalGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacologicalGroups_UserID",
                table: "PharmacologicalGroups",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicaments_PharmacologicalGroups_PharmacologicalGroupID",
                table: "Medicaments",
                column: "PharmacologicalGroupID",
                principalTable: "PharmacologicalGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

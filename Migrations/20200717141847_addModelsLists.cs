using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp_Semus.Migrations
{
    public partial class addModelsLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PharmacologicalGroups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    SectionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacologicalGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PharmacologicalGroups_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirstSubGroups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    PharmacologicalGroupID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstSubGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FirstSubGroups_PharmacologicalGroups_PharmacologicalGroupID",
                        column: x => x.PharmacologicalGroupID,
                        principalTable: "PharmacologicalGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecondSubGroups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    FirstSubGroupID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondSubGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SecondSubGroups_FirstSubGroups_FirstSubGroupID",
                        column: x => x.FirstSubGroupID,
                        principalTable: "FirstSubGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThirdSubGroups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    SecondSubGroupID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdSubGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThirdSubGroups_SecondSubGroups_SecondSubGroupID",
                        column: x => x.SecondSubGroupID,
                        principalTable: "SecondSubGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FirstSubGroups_PharmacologicalGroupID",
                table: "FirstSubGroups",
                column: "PharmacologicalGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacologicalGroups_SectionID",
                table: "PharmacologicalGroups",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_SecondSubGroups_FirstSubGroupID",
                table: "SecondSubGroups",
                column: "FirstSubGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdSubGroups_SecondSubGroupID",
                table: "ThirdSubGroups",
                column: "SecondSubGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThirdSubGroups");

            migrationBuilder.DropTable(
                name: "SecondSubGroups");

            migrationBuilder.DropTable(
                name: "FirstSubGroups");

            migrationBuilder.DropTable(
                name: "PharmacologicalGroups");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}

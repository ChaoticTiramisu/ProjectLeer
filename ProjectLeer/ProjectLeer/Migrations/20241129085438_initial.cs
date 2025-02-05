using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLeer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leerkrachten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    Klassen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leerkrachten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leerlingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    Klas = table.Column<string>(type: "TEXT", nullable: true),
                    Graad = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leerlingen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vakken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    LeerkrachtId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vakken_Leerkrachten_LeerkrachtId",
                        column: x => x.LeerkrachtId,
                        principalTable: "Leerkrachten",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeerlingVak",
                columns: table => new
                {
                    LeerlingId = table.Column<int>(type: "INTEGER", nullable: false),
                    VakkenId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeerlingVak", x => new { x.LeerlingId, x.VakkenId });
                    table.ForeignKey(
                        name: "FK_LeerlingVak_Leerlingen_LeerlingId",
                        column: x => x.LeerlingId,
                        principalTable: "Leerlingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeerlingVak_Vakken_VakkenId",
                        column: x => x.VakkenId,
                        principalTable: "Vakken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeerlingVak_VakkenId",
                table: "LeerlingVak",
                column: "VakkenId");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_LeerkrachtId",
                table: "Vakken",
                column: "LeerkrachtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeerlingVak");

            migrationBuilder.DropTable(
                name: "Leerlingen");

            migrationBuilder.DropTable(
                name: "Vakken");

            migrationBuilder.DropTable(
                name: "Leerkrachten");
        }
    }
}

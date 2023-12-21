using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceAgendaPraticien.Migrations
{
    public partial class migDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Praticiens",
                columns: table => new
                {
                    PaticienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Praticiens", x => x.PaticienId);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    AgendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PraticienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.AgendaId);
                    table.ForeignKey(
                        name: "FK_Agenda_Praticiens_PraticienId",
                        column: x => x.PraticienId,
                        principalTable: "Praticiens",
                        principalColumn: "PaticienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PraticienId",
                table: "Agenda",
                column: "PraticienId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Praticiens");
        }
    }
}

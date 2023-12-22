using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceAgendaPraticien.Migrations
{
    public partial class migFixEntitePraticien : Migration
    {
        //essai modif pour git bash
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaticienId",
                table: "Praticiens",
                newName: "PraticienId");

            migrationBuilder.AlterColumn<string>(
                name: "Specialite",
                table: "Praticiens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PraticienId",
                table: "Praticiens",
                newName: "PaticienId");

            migrationBuilder.AlterColumn<int>(
                name: "Specialite",
                table: "Praticiens",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

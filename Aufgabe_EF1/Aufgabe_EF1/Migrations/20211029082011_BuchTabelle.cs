using Microsoft.EntityFrameworkCore.Migrations;

namespace Aufgabe_EF1.Migrations
{
    public partial class BuchTabelle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buch",
                columns: table => new
                {
                    Buch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Autor_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buch", x => x.Buch_ID);
                    table.ForeignKey(
                        name: "FK_Buch_Autor_Autor_ID",
                        column: x => x.Autor_ID,
                        principalTable: "Autor",
                        principalColumn: "Autor_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buch_Autor_ID",
                table: "Buch",
                column: "Autor_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buch");
        }
    }
}

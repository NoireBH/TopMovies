using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddQuotesToCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "MovieCharacters");

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieCharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_MovieCharacters_MovieCharacterId",
                        column: x => x.MovieCharacterId,
                        principalTable: "MovieCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_MovieCharacterId",
                table: "Quotes",
                column: "MovieCharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MovieCharacters",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");
        }
    }
}

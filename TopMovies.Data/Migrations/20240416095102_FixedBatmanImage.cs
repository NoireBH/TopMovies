using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class FixedBatmanImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/M/MV5BMTQyODI2MDczOF5BMl5BanBnXkFtZTcwNDczMTk2Mw@@._V1_FMjpg_UY2048_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/M/MV5BYmMyZTNiZjItMjZkOC00NDRkLTg5YTEtZDFjODBlODliYjYxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg");
        }
    }
}

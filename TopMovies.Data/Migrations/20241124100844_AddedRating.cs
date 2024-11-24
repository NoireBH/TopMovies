using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddedRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "UserReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("129d8177-95e3-404f-872e-eb94fe803bd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6fabe130-8b78-48fd-a2fb-94923cce8966", "AQAAAAEAACcQAAAAEBzssdln2CioKMiccDc6h/T8tR9YrUfpn3UIRgjbtdqmoG+uBHefG23P/JMqotXNdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2110c067-48d9-441a-a1eb-c723466b60c0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f435746-2542-4426-bf99-355f03bc5de2", "AQAAAAEAACcQAAAAECUrhdJXtNEjJ/oEzAou55LwEBhSBf/54mnLzZpAKotXYoDunJ0yzkNrLmJtggDYiw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e11f771c-1b10-41eb-81bc-0683dd00b080"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44068f82-9e47-4d1a-a4bf-70970a7ae60d", "AQAAAAEAACcQAAAAEH3csxi8z+xFw0j9Tgn28CASqz4VSFtizRLxQzs3ZGpoLapX3754j3TcI2srQ0ot0g==" });

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("176697c8-9480-447a-9e86-07b70b0a6585"),
                column: "Rating",
                value: 8);

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("8efd4094-5824-434c-9019-eafb5cce9510"),
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("96475262-852c-442f-b88c-8642835ecb30"),
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("ecd7d309-aa53-44bb-b876-27a6bf213dc5"),
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("fbd5e0af-4c33-411b-a0b3-88d7863f9d6e"),
                column: "Rating",
                value: 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "UserReviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("129d8177-95e3-404f-872e-eb94fe803bd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e66b716c-fe6b-4836-a268-10987a23b4f0", "AQAAAAEAACcQAAAAEJdBk6FDDt4o6+l84PXPoVJHTohzgYnMWwZT3+KluFDm5CgFnP5lQbV3Qnyz2hZ2AQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2110c067-48d9-441a-a1eb-c723466b60c0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d08beac8-cbd6-41f8-bac9-03de5d8b9641", "AQAAAAEAACcQAAAAEDlKixfsR4l/6RjlLaHRYn/2EQ3oiPimfW1XHLHTPvspN5y20d3QulG0Nzm9FEsU1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e11f771c-1b10-41eb-81bc-0683dd00b080"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "024c8b3e-69c7-424e-9594-4faf292aee88", "AQAAAAEAACcQAAAAEEUaaBMY+VmM+iJcrN1fA+bvYgewA3Qq/2RdZdCywFb0mGiUf4konVMmcL4dhZnndQ==" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddedUserSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("129d8177-95e3-404f-872e-eb94fe803bd1"), 0, "24d32a09-c7a4-466e-a85b-4d28a5b30f97", "admin_topmovies@gmail.com", true, false, null, "ADMIN_TOPMOVIES@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEMpC7BjKFXguSKOOmj9Hrk6i0zg9HlAGYL12R5S8ZZ3lTvB1uRzH7pArFvBhOQVkYA==", null, false, null, false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2110c067-48d9-441a-a1eb-c723466b60c0"), 0, "b3aab15b-9bb5-4454-a70a-9670a09c837d", "SecondUser@abv.bg", true, false, null, "SECONDUSER@ABV.BG", "SECONDUSER", "AQAAAAEAACcQAAAAEM2FJ4lBObWE5OJQUOYUopmhiNVXliyOpW0JGxC8aTF3LS6/Af5dOPmoYiPjou3HPQ==", null, false, null, false, "secondtUser" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e11f771c-1b10-41eb-81bc-0683dd00b080"), 0, "f8a181a9-fefe-49de-9e23-4815bbc8c62a", "FirstUser@abv.bg", true, false, null, "FIRSTUSER@ABV.BG", "FIRSTUSER", "AQAAAAEAACcQAAAAEJiHaH0hdnSDUfhyE9IoJKuRteb3sBsNxWQCsa1DSgtAC4olWZaR+tl3l6F3LpQchw==", null, false, null, false, "firstUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("129d8177-95e3-404f-872e-eb94fe803bd1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2110c067-48d9-441a-a1eb-c723466b60c0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e11f771c-1b10-41eb-81bc-0683dd00b080"));
        }
    }
}

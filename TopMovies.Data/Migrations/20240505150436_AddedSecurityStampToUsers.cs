using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddedSecurityStampToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("129d8177-95e3-404f-872e-eb94fe803bd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e66b716c-fe6b-4836-a268-10987a23b4f0", "AQAAAAEAACcQAAAAEJdBk6FDDt4o6+l84PXPoVJHTohzgYnMWwZT3+KluFDm5CgFnP5lQbV3Qnyz2hZ2AQ==", "DE313F5D-BCF1-43F0-8115-8FC46B08522C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2110c067-48d9-441a-a1eb-c723466b60c0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d08beac8-cbd6-41f8-bac9-03de5d8b9641", "AQAAAAEAACcQAAAAEDlKixfsR4l/6RjlLaHRYn/2EQ3oiPimfW1XHLHTPvspN5y20d3QulG0Nzm9FEsU1Q==", "96476EAD-3160-42A5-9116-294DF4E849D2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e11f771c-1b10-41eb-81bc-0683dd00b080"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "024c8b3e-69c7-424e-9594-4faf292aee88", "AQAAAAEAACcQAAAAEEUaaBMY+VmM+iJcrN1fA+bvYgewA3Qq/2RdZdCywFb0mGiUf4konVMmcL4dhZnndQ==", "BF648745-8661-43F4-8173-9EA6EB66931F" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("129d8177-95e3-404f-872e-eb94fe803bd1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24d32a09-c7a4-466e-a85b-4d28a5b30f97", "AQAAAAEAACcQAAAAEMpC7BjKFXguSKOOmj9Hrk6i0zg9HlAGYL12R5S8ZZ3lTvB1uRzH7pArFvBhOQVkYA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2110c067-48d9-441a-a1eb-c723466b60c0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3aab15b-9bb5-4454-a70a-9670a09c837d", "AQAAAAEAACcQAAAAEM2FJ4lBObWE5OJQUOYUopmhiNVXliyOpW0JGxC8aTF3LS6/Af5dOPmoYiPjou3HPQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e11f771c-1b10-41eb-81bc-0683dd00b080"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8a181a9-fefe-49de-9e23-4815bbc8c62a", "AQAAAAEAACcQAAAAEJiHaH0hdnSDUfhyE9IoJKuRteb3sBsNxWQCsa1DSgtAC4olWZaR+tl3l6F3LpQchw==", null });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddedUserReviewSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "MovieId" },
                values: new object[,]
                {
                    { new Guid("176697c8-9480-447a-9e86-07b70b0a6585"), new Guid("2e5c284d-e571-40c1-97b0-18505632fe70"), "A classic! My only complaint is that the pacing was too slow for my taste.If you have ADHD like me you're gonna have a hard time watching this movie, but i still think it's worth watching!", new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { new Guid("8efd4094-5824-434c-9019-eafb5cce9510"), new Guid("84a02b87-df1d-4f33-becd-44138f88a11a"), "Peak fiction, they don't make dark batman movies like this anymore...", new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { new Guid("96475262-852c-442f-b88c-8642835ecb30"), new Guid("84a02b87-df1d-4f33-becd-44138f88a11a"), "Not that great. Didn't remain consistent with Batman Begins and was extremely predictable. The plot and action labors along and never reaches a satisfying conclusion. The best thing about this film is the score.\r\n", new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { new Guid("ecd7d309-aa53-44bb-b876-27a6bf213dc5"), new Guid("2e5c284d-e571-40c1-97b0-18505632fe70"), "One of the best movies I've ever seen!", new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { new Guid("fbd5e0af-4c33-411b-a0b3-88d7863f9d6e"), new Guid("84a02b87-df1d-4f33-becd-44138f88a11a"), "While good it's extremely overrated", new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("176697c8-9480-447a-9e86-07b70b0a6585"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("8efd4094-5824-434c-9019-eafb5cce9510"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("96475262-852c-442f-b88c-8642835ecb30"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("ecd7d309-aa53-44bb-b876-27a6bf213dc5"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("fbd5e0af-4c33-411b-a0b3-88d7863f9d6e"));
        }
    }
}

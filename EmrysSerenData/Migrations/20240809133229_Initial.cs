using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmrysSerenData.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogTag",
                columns: table => new
                {
                    BlogTagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogTagString = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTag", x => x.BlogTagId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    UserEmail = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostDetail",
                columns: table => new
                {
                    BlogPostDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogPostTitle = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogPostTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostDetail", x => x.BlogPostDetailId);
                    table.ForeignKey(
                        name: "FK_BlogPostDetail_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentPost",
                columns: table => new
                {
                    CommentPostId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    CommentPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentPostTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentPost", x => x.CommentPostId);
                    table.ForeignKey(
                        name: "FK_CommentPost_BlogPostDetail_CommentPostId",
                        column: x => x.CommentPostId,
                        principalTable: "BlogPostDetail",
                        principalColumn: "BlogPostDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentPost_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "UserEmail", "UserName" },
                values: new object[,]
                {
                    { 1, "serenityaithne@gmail.com", "Emrys Seren" },
                    { 2, "brandi.hornbuckle@gmail.com", "Cosmic Ides" }
                });

            migrationBuilder.InsertData(
                table: "BlogPostDetail",
                columns: new[] { "BlogPostDetailId", "BlogPostBody", "BlogPostDate", "BlogPostTime", "BlogPostTitle", "UserId", "UserName" },
                values: new object[] { 1, "Hi, I’m Emrys Seren, also called Emmeryn. I’m a disabled artist from the midwestern United States. I enjoy fantasy and magic especially, so the majority of my works are fantasy. But I also enjoy autobiographical comics. \r\n\r\nI spend quite a lot of time on native restoration in the garden, planting flowers and learning about my local ecosystem. My favorite animal is actually the moth, so the majority of plants are grown for them. \r\n\r\nMy cat, Hoshi, is also called Egg. It’s because she’s egg shaped. She’s the sweetest little cat ever and clings to me while she sleeps. She also follows me around, rubbing against my legs. However sometimes she feels anxiety around other cats and tries to commit atrocities. When this happens she is placed in an alternate room to cool down. What a good cat. \r\n\r\nYou have entered my domain, where the posts will be about things I like, like fantasy, moths, and cats. Welcome. \r\n", new DateTime(2024, 8, 9, 9, 32, 29, 25, DateTimeKind.Local).AddTicks(7288), new DateTime(2024, 8, 9, 9, 32, 29, 25, DateTimeKind.Local).AddTicks(7332), "Introduction", 1, "Emrys Seren" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetail_UserId",
                table: "BlogPostDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentPost_UserId",
                table: "CommentPost",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogTag");

            migrationBuilder.DropTable(
                name: "CommentPost");

            migrationBuilder.DropTable(
                name: "BlogPostDetail");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

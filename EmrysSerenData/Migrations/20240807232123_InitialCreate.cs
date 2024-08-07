using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmrysSerenData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    BlogTagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogTagString = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.BlogTagId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    UserEmail = table.Column<string>(type: "TEXT", nullable: false),
                    UserAvatar = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostDetails",
                columns: table => new
                {
                    BlogPostDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogPostTitle = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogPostTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogTagId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostDetails", x => x.BlogPostDetailId);
                    table.ForeignKey(
                        name: "FK_BlogPostDetails_BlogTags_BlogTagId",
                        column: x => x.BlogTagId,
                        principalTable: "BlogTags",
                        principalColumn: "BlogTagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentPosts",
                columns: table => new
                {
                    CommentPostId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    CommentPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentPostTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentCount = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentPosts", x => x.CommentPostId);
                    table.ForeignKey(
                        name: "FK_CommentPosts_BlogPostDetails_CommentPostId",
                        column: x => x.CommentPostId,
                        principalTable: "BlogPostDetails",
                        principalColumn: "BlogPostDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetails_BlogTagId",
                table: "BlogPostDetails",
                column: "BlogTagId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetails_UserId",
                table: "BlogPostDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentPosts_UserId",
                table: "CommentPosts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentPosts");

            migrationBuilder.DropTable(
                name: "BlogPostDetails");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

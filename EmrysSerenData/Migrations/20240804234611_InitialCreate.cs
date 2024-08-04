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
                name: "BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogPostTitle = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogPostTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
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
                name: "BlogTag",
                columns: table => new
                {
                    BlogTagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogTagString = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTag", x => x.BlogTagId);
                    table.ForeignKey(
                        name: "FK_BlogTag_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId");
                });

            migrationBuilder.CreateTable(
                name: "BlogPostDetails",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentPostId = table.Column<int>(type: "INTEGER", nullable: false),
                    BlogPostTitle = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    BlogPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogPostTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BlogTagId = table.Column<int>(type: "INTEGER", nullable: false),
                    BlogTagString = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    UserEmail = table.Column<string>(type: "TEXT", nullable: false),
                    UserAvatar = table.Column<byte[]>(type: "BLOB", nullable: false),
                    CommentPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    CommentPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentPostTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostDetails", x => new { x.BlogPostId, x.CommentPostId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BlogPostDetails_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostDetails_BlogTag_BlogTagId",
                        column: x => x.BlogTagId,
                        principalTable: "BlogTag",
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
                    CommentPostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    CommentPostDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentPostTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentCount = table.Column<int>(type: "INTEGER", nullable: false),
                    BlogPostDetailBlogPostId = table.Column<int>(type: "INTEGER", nullable: true),
                    BlogPostDetailCommentPostId = table.Column<int>(type: "INTEGER", nullable: true),
                    BlogPostDetailUserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentPosts", x => x.CommentPostId);
                    table.ForeignKey(
                        name: "FK_CommentPosts_BlogPostDetails_BlogPostDetailBlogPostId_BlogPostDetailCommentPostId_BlogPostDetailUserId",
                        columns: x => new { x.BlogPostDetailBlogPostId, x.BlogPostDetailCommentPostId, x.BlogPostDetailUserId },
                        principalTable: "BlogPostDetails",
                        principalColumns: new[] { "BlogPostId", "CommentPostId", "UserId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetails_BlogTagId",
                table: "BlogPostDetails",
                column: "BlogTagId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetails_CommentPostId",
                table: "BlogPostDetails",
                column: "CommentPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetails_UserId",
                table: "BlogPostDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTag_BlogPostId",
                table: "BlogTag",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentPosts_BlogPostDetailBlogPostId_BlogPostDetailCommentPostId_BlogPostDetailUserId",
                table: "CommentPosts",
                columns: new[] { "BlogPostDetailBlogPostId", "BlogPostDetailCommentPostId", "BlogPostDetailUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostDetails_CommentPosts_CommentPostId",
                table: "BlogPostDetails",
                column: "CommentPostId",
                principalTable: "CommentPosts",
                principalColumn: "CommentPostId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostDetails_BlogPosts_BlogPostId",
                table: "BlogPostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogTag_BlogPosts_BlogPostId",
                table: "BlogTag");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostDetails_BlogTag_BlogTagId",
                table: "BlogPostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostDetails_CommentPosts_CommentPostId",
                table: "BlogPostDetails");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "BlogTag");

            migrationBuilder.DropTable(
                name: "CommentPosts");

            migrationBuilder.DropTable(
                name: "BlogPostDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

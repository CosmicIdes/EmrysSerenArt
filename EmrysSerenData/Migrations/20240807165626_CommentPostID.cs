using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmrysSerenData.Migrations
{
    /// <inheritdoc />
    public partial class CommentPostID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostDetails_BlogTag_BlogTagId",
                table: "BlogPostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostDetails_CommentPosts_CommentPostId",
                table: "BlogPostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogTag_BlogPosts_BlogPostId",
                table: "BlogTag");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentPosts_BlogPostDetails_BlogPostDetailBlogPostId_BlogPostDetailCommentPostId_BlogPostDetailUserId",
                table: "CommentPosts");

            migrationBuilder.DropIndex(
                name: "IX_CommentPosts_BlogPostDetailBlogPostId_BlogPostDetailCommentPostId_BlogPostDetailUserId",
                table: "CommentPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostDetails",
                table: "BlogPostDetails");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostDetails_CommentPostId",
                table: "BlogPostDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogTag",
                table: "BlogTag");

            migrationBuilder.DropColumn(
                name: "BlogPostDetailBlogPostId",
                table: "CommentPosts");

            migrationBuilder.DropColumn(
                name: "BlogPostDetailCommentPostId",
                table: "CommentPosts");

            migrationBuilder.DropColumn(
                name: "BlogPostDetailUserId",
                table: "CommentPosts");

            migrationBuilder.DropColumn(
                name: "BlogTagString",
                table: "BlogPostDetails");

            migrationBuilder.DropColumn(
                name: "CommentPostBody",
                table: "BlogPostDetails");

            migrationBuilder.DropColumn(
                name: "CommentPostDate",
                table: "BlogPostDetails");

            migrationBuilder.DropColumn(
                name: "CommentPostTime",
                table: "BlogPostDetails");

            migrationBuilder.DropColumn(
                name: "UserAvatar",
                table: "BlogPostDetails");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "BlogPostDetails");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "BlogPostDetails");

            migrationBuilder.RenameTable(
                name: "BlogTag",
                newName: "BlogTags");

            migrationBuilder.RenameColumn(
                name: "CommentCount",
                table: "BlogPostDetails",
                newName: "CommentPostId1");

            migrationBuilder.RenameIndex(
                name: "IX_BlogTag_BlogPostId",
                table: "BlogTags",
                newName: "IX_BlogTags_BlogPostId");

            migrationBuilder.AddColumn<int>(
                name: "BlogPostId1",
                table: "CommentPosts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "CommentPosts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CommentPostId",
                table: "BlogPostDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostDetails",
                table: "BlogPostDetails",
                columns: new[] { "BlogPostId", "CommentPostId", "UserId", "BlogTagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogTags",
                table: "BlogTags",
                column: "BlogTagId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentPosts_BlogPostId1",
                table: "CommentPosts",
                column: "BlogPostId1");

            migrationBuilder.CreateIndex(
                name: "IX_CommentPosts_UserId1",
                table: "CommentPosts",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetails_CommentPostId1",
                table: "BlogPostDetails",
                column: "CommentPostId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostDetails_BlogTags_BlogTagId",
                table: "BlogPostDetails",
                column: "BlogTagId",
                principalTable: "BlogTags",
                principalColumn: "BlogTagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostDetails_CommentPosts_CommentPostId1",
                table: "BlogPostDetails",
                column: "CommentPostId1",
                principalTable: "CommentPosts",
                principalColumn: "CommentPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTags_BlogPosts_BlogPostId",
                table: "BlogTags",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentPosts_BlogPosts_BlogPostId1",
                table: "CommentPosts",
                column: "BlogPostId1",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentPosts_Users_UserId1",
                table: "CommentPosts",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostDetails_BlogTags_BlogTagId",
                table: "BlogPostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostDetails_CommentPosts_CommentPostId1",
                table: "BlogPostDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogTags_BlogPosts_BlogPostId",
                table: "BlogTags");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentPosts_BlogPosts_BlogPostId1",
                table: "CommentPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentPosts_Users_UserId1",
                table: "CommentPosts");

            migrationBuilder.DropIndex(
                name: "IX_CommentPosts_BlogPostId1",
                table: "CommentPosts");

            migrationBuilder.DropIndex(
                name: "IX_CommentPosts_UserId1",
                table: "CommentPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostDetails",
                table: "BlogPostDetails");

            migrationBuilder.DropIndex(
                name: "IX_BlogPostDetails_CommentPostId1",
                table: "BlogPostDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogTags",
                table: "BlogTags");

            migrationBuilder.DropColumn(
                name: "BlogPostId1",
                table: "CommentPosts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CommentPosts");

            migrationBuilder.RenameTable(
                name: "BlogTags",
                newName: "BlogTag");

            migrationBuilder.RenameColumn(
                name: "CommentPostId1",
                table: "BlogPostDetails",
                newName: "CommentCount");

            migrationBuilder.RenameIndex(
                name: "IX_BlogTags_BlogPostId",
                table: "BlogTag",
                newName: "IX_BlogTag_BlogPostId");

            migrationBuilder.AddColumn<int>(
                name: "BlogPostDetailBlogPostId",
                table: "CommentPosts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogPostDetailCommentPostId",
                table: "CommentPosts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogPostDetailUserId",
                table: "CommentPosts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CommentPostId",
                table: "BlogPostDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "BlogTagString",
                table: "BlogPostDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CommentPostBody",
                table: "BlogPostDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CommentPostDate",
                table: "BlogPostDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CommentPostTime",
                table: "BlogPostDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "UserAvatar",
                table: "BlogPostDetails",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "BlogPostDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "BlogPostDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostDetails",
                table: "BlogPostDetails",
                columns: new[] { "BlogPostId", "CommentPostId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogTag",
                table: "BlogTag",
                column: "BlogTagId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentPosts_BlogPostDetailBlogPostId_BlogPostDetailCommentPostId_BlogPostDetailUserId",
                table: "CommentPosts",
                columns: new[] { "BlogPostDetailBlogPostId", "BlogPostDetailCommentPostId", "BlogPostDetailUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostDetails_CommentPostId",
                table: "BlogPostDetails",
                column: "CommentPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostDetails_BlogTag_BlogTagId",
                table: "BlogPostDetails",
                column: "BlogTagId",
                principalTable: "BlogTag",
                principalColumn: "BlogTagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostDetails_CommentPosts_CommentPostId",
                table: "BlogPostDetails",
                column: "CommentPostId",
                principalTable: "CommentPosts",
                principalColumn: "CommentPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTag_BlogPosts_BlogPostId",
                table: "BlogTag",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "BlogPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentPosts_BlogPostDetails_BlogPostDetailBlogPostId_BlogPostDetailCommentPostId_BlogPostDetailUserId",
                table: "CommentPosts",
                columns: new[] { "BlogPostDetailBlogPostId", "BlogPostDetailCommentPostId", "BlogPostDetailUserId" },
                principalTable: "BlogPostDetails",
                principalColumns: new[] { "BlogPostId", "CommentPostId", "UserId" });
        }
    }
}

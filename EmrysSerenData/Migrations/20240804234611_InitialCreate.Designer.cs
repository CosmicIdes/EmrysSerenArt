﻿// <auto-generated />
using System;
using EmrysSerenData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmrysSerenData.Migrations
{
    [DbContext(typeof(ESDbContext))]
    [Migration("20240804234611_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("EmrysSerenShared.BlogPost", b =>
                {
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogPostBody")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BlogPostDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BlogPostTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogPostTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BlogPostId");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogPostDetail", b =>
                {
                    b.Property<int>("BlogPostId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommentPostId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogPostBody")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BlogPostDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BlogPostTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogPostTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BlogTagId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogTagString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CommentCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentPostBody")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CommentPostDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CommentPostTime")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("UserAvatar")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BlogPostId", "CommentPostId", "UserId");

                    b.HasIndex("BlogTagId");

                    b.HasIndex("CommentPostId");

                    b.HasIndex("UserId");

                    b.ToTable("BlogPostDetails");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogTag", b =>
                {
                    b.Property<int>("BlogTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogPostId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogTagString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BlogTagId");

                    b.HasIndex("BlogPostId");

                    b.ToTable("BlogTag");
                });

            modelBuilder.Entity("EmrysSerenShared.CommentPost", b =>
                {
                    b.Property<int>("CommentPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogPostDetailBlogPostId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogPostDetailCommentPostId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogPostDetailUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommentCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentPostBody")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CommentPostDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CommentPostTime")
                        .HasColumnType("TEXT");

                    b.HasKey("CommentPostId");

                    b.HasIndex("BlogPostDetailBlogPostId", "BlogPostDetailCommentPostId", "BlogPostDetailUserId");

                    b.ToTable("CommentPosts");
                });

            modelBuilder.Entity("EmrysSerenShared.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("UserAvatar")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogPostDetail", b =>
                {
                    b.HasOne("EmrysSerenShared.BlogPost", "BlogPost")
                        .WithMany()
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmrysSerenShared.BlogTag", "BlogTag")
                        .WithMany()
                        .HasForeignKey("BlogTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmrysSerenShared.CommentPost", "CommentPost")
                        .WithMany()
                        .HasForeignKey("CommentPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmrysSerenShared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogPost");

                    b.Navigation("BlogTag");

                    b.Navigation("CommentPost");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogTag", b =>
                {
                    b.HasOne("EmrysSerenShared.BlogPost", null)
                        .WithMany("BlogTags")
                        .HasForeignKey("BlogPostId");
                });

            modelBuilder.Entity("EmrysSerenShared.CommentPost", b =>
                {
                    b.HasOne("EmrysSerenShared.BlogPostDetail", null)
                        .WithMany("CommentPosts")
                        .HasForeignKey("BlogPostDetailBlogPostId", "BlogPostDetailCommentPostId", "BlogPostDetailUserId");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogPost", b =>
                {
                    b.Navigation("BlogTags");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogPostDetail", b =>
                {
                    b.Navigation("CommentPosts");
                });
#pragma warning restore 612, 618
        }
    }
}

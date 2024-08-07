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
    [Migration("20240807232123_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("EmrysSerenShared.BlogPostDetail", b =>
                {
                    b.Property<int>("BlogPostDetailId")
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

                    b.Property<int>("BlogTagId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BlogPostDetailId");

                    b.HasIndex("BlogTagId");

                    b.HasIndex("UserId");

                    b.ToTable("BlogPostDetails");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogTag", b =>
                {
                    b.Property<int>("BlogTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogTagString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BlogTagId");

                    b.ToTable("BlogTags");
                });

            modelBuilder.Entity("EmrysSerenShared.CommentPost", b =>
                {
                    b.Property<int>("CommentPostId")
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

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentPostId");

                    b.HasIndex("UserId");

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
                    b.HasOne("EmrysSerenShared.BlogTag", "BlogTag")
                        .WithMany()
                        .HasForeignKey("BlogTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmrysSerenShared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogTag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EmrysSerenShared.CommentPost", b =>
                {
                    b.HasOne("EmrysSerenShared.BlogPostDetail", "BlogPostDetail")
                        .WithMany("CommentPosts")
                        .HasForeignKey("CommentPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmrysSerenShared.User", "User")
                        .WithMany("CommentPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogPostDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EmrysSerenShared.BlogPostDetail", b =>
                {
                    b.Navigation("CommentPosts");
                });

            modelBuilder.Entity("EmrysSerenShared.User", b =>
                {
                    b.Navigation("CommentPosts");
                });
#pragma warning restore 612, 618
        }
    }
}
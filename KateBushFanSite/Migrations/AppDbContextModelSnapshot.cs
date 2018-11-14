﻿// <auto-generated />
using KateBushFanSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace KateBushFanSite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KateBushFanSite.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentText");

                    b.Property<int?>("StoryID");

                    b.HasKey("CommentID");

                    b.HasIndex("StoryID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("KateBushFanSite.Models.PrintSource", b =>
                {
                    b.Property<int>("PrintSourceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Title");

                    b.HasKey("PrintSourceID");

                    b.ToTable("PrintSources");
                });

            modelBuilder.Entity("KateBushFanSite.Models.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RatingNumber");

                    b.Property<int?>("StoryID");

                    b.HasKey("RatingID");

                    b.HasIndex("StoryID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("KateBushFanSite.Models.Story", b =>
                {
                    b.Property<int>("StoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("StoryText")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("StoryID");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("KateBushFanSite.Models.WebSource", b =>
                {
                    b.Property<int>("WebSourceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("WebSourceID");

                    b.ToTable("WebSources");
                });

            modelBuilder.Entity("KateBushFanSite.Models.Comment", b =>
                {
                    b.HasOne("KateBushFanSite.Models.Story")
                        .WithMany("Comments")
                        .HasForeignKey("StoryID");
                });

            modelBuilder.Entity("KateBushFanSite.Models.Rating", b =>
                {
                    b.HasOne("KateBushFanSite.Models.Story")
                        .WithMany("Ratings")
                        .HasForeignKey("StoryID");
                });
#pragma warning restore 612, 618
        }
    }
}

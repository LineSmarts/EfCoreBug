﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EfCoreBug.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("EFGetStarted.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post10Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post11Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post12Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post1Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post2Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post3Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post4Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post5Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post6Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post7Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post8Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Post9Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Post10Id");

                    b.HasIndex("Post11Id");

                    b.HasIndex("Post12Id");

                    b.HasIndex("Post1Id");

                    b.HasIndex("Post2Id");

                    b.HasIndex("Post3Id");

                    b.HasIndex("Post4Id");

                    b.HasIndex("Post5Id");

                    b.HasIndex("Post6Id");

                    b.HasIndex("Post7Id");

                    b.HasIndex("Post8Id");

                    b.HasIndex("Post9Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EFGetStarted.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EFGetStarted.Blog", b =>
                {
                    b.HasOne("EFGetStarted.Post", "Post10")
                        .WithMany()
                        .HasForeignKey("Post10Id");

                    b.HasOne("EFGetStarted.Post", "Post11")
                        .WithMany()
                        .HasForeignKey("Post11Id");

                    b.HasOne("EFGetStarted.Post", "Post12")
                        .WithMany()
                        .HasForeignKey("Post12Id");

                    b.HasOne("EFGetStarted.Post", "Post1")
                        .WithMany()
                        .HasForeignKey("Post1Id");

                    b.HasOne("EFGetStarted.Post", "Post2")
                        .WithMany()
                        .HasForeignKey("Post2Id");

                    b.HasOne("EFGetStarted.Post", "Post3")
                        .WithMany()
                        .HasForeignKey("Post3Id");

                    b.HasOne("EFGetStarted.Post", "Post4")
                        .WithMany()
                        .HasForeignKey("Post4Id");

                    b.HasOne("EFGetStarted.Post", "Post5")
                        .WithMany()
                        .HasForeignKey("Post5Id");

                    b.HasOne("EFGetStarted.Post", "Post6")
                        .WithMany()
                        .HasForeignKey("Post6Id");

                    b.HasOne("EFGetStarted.Post", "Post7")
                        .WithMany()
                        .HasForeignKey("Post7Id");

                    b.HasOne("EFGetStarted.Post", "Post8")
                        .WithMany()
                        .HasForeignKey("Post8Id");

                    b.HasOne("EFGetStarted.Post", "Post9")
                        .WithMany()
                        .HasForeignKey("Post9Id");

                    b.Navigation("Post1");

                    b.Navigation("Post10");

                    b.Navigation("Post11");

                    b.Navigation("Post12");

                    b.Navigation("Post2");

                    b.Navigation("Post3");

                    b.Navigation("Post4");

                    b.Navigation("Post5");

                    b.Navigation("Post6");

                    b.Navigation("Post7");

                    b.Navigation("Post8");

                    b.Navigation("Post9");
                });
#pragma warning restore 612, 618
        }
    }
}

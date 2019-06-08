﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalDiary.Data;

namespace PersonalDiary.Migrations
{
    [DbContext(typeof(DiaryContext))]
    [Migration("20190608193715_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonalDiary.Models.Diary", b =>
                {
                    b.Property<int>("DiaryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Title");

                    b.HasKey("DiaryID");

                    b.ToTable("Diaries");
                });

            modelBuilder.Entity("PersonalDiary.Models.Entry", b =>
                {
                    b.Property<int>("EntryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("DiaryID");

                    b.Property<string>("Text");

                    b.HasKey("EntryID");

                    b.HasIndex("DiaryID");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("PersonalDiary.Models.Entry", b =>
                {
                    b.HasOne("PersonalDiary.Models.Diary")
                        .WithMany("Entries")
                        .HasForeignKey("DiaryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

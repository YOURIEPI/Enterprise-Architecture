﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Note.DAL.DataContext;
using System;

namespace Note.DAL.Migrations
{
    [DbContext(typeof(NoteDbContext))]
    partial class NoteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Note.Model.Notice", b =>
                {
                    b.Property<int>("NoticeNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NoticeContents")
                        .IsRequired();

                    b.Property<string>("NoticeTitle")
                        .IsRequired();

                    b.Property<DateTime>("NoticeWriteDate");

                    b.HasKey("NoticeNo");

                    b.ToTable("Notices");
                });
#pragma warning restore 612, 618
        }
    }
}
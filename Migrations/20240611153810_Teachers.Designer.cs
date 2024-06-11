﻿// <auto-generated />
using System;
using CRUDapplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDapplication.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240611153810_Teachers")]
    partial class Teachers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUDapplication.Models.Entity.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CRUDapplication.Models.Entity.Teacher", b =>
                {
                    b.Property<int>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Guid"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherGuid")
                        .HasColumnType("int");

                    b.HasKey("Guid");

                    b.HasIndex("TeacherGuid");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CRUDapplication.Models.Entity.Student", b =>
                {
                    b.HasOne("CRUDapplication.Models.Entity.Student", null)
                        .WithMany("Students")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("CRUDapplication.Models.Entity.Teacher", b =>
                {
                    b.HasOne("CRUDapplication.Models.Entity.Teacher", null)
                        .WithMany("Teachers")
                        .HasForeignKey("TeacherGuid");
                });

            modelBuilder.Entity("CRUDapplication.Models.Entity.Student", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("CRUDapplication.Models.Entity.Teacher", b =>
                {
                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
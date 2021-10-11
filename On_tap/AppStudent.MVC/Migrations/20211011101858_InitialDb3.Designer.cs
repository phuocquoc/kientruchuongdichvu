﻿// <auto-generated />
using AppStudent.MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppStudent.MVC.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211011101858_InitialDb3")]
    partial class InitialDb3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("AppStudent.MVC.Models.Class_SV", b =>
                {
                    b.Property<int>("ID_Lop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameLop")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Lop");

                    b.ToTable("Class_SV");
                });

            modelBuilder.Entity("AppStudent.MVC.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ID_Lop")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("id");

                    b.HasIndex("ID_Lop");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AppStudent.MVC.Models.Student", b =>
                {
                    b.HasOne("AppStudent.MVC.Models.Class_SV", "_idLop")
                        .WithMany("Students")
                        .HasForeignKey("ID_Lop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_idLop");
                });

            modelBuilder.Entity("AppStudent.MVC.Models.Class_SV", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}

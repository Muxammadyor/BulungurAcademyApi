﻿// <auto-generated />
using System;
using BulungurAcademy.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulungurAcademy.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.ExamApplicant", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("FirstSubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SecondSubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "ExamId");

                    b.HasIndex("ExamId");

                    b.HasIndex("FirstSubjectId");

                    b.HasIndex("SecondSubjectId");

                    b.ToTable("ExamApplicant");
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.ExamSubjects.ExamSubject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubjectId", "ExamId");

                    b.HasIndex("ExamId");

                    b.ToTable("ExamsSubjects", (string)null);
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.Exams.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Exams", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("be04ecde-1fc4-4716-be35-eef6d6d8e910"),
                            CreatedAt = new DateTime(2023, 2, 12, 17, 21, 22, 206, DateTimeKind.Local).AddTicks(4142),
                            ExamDate = new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExamName = "Imtihon 1",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.Subjects.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Subjects", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("be04ecde-1fc4-4716-be35-eef6d6d8e910"),
                            CreatedAt = new DateTime(2023, 2, 12, 17, 21, 22, 207, DateTimeKind.Local).AddTicks(3738),
                            Name = "Matematika",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c73b5db9-da88-45e9-8036-5db97202bd48"),
                            CreatedAt = new DateTime(2023, 2, 12, 17, 21, 22, 207, DateTimeKind.Local).AddTicks(3750),
                            Name = "Fizika",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("TelegramId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("baa9d7c1-9b8a-4f33-ba88-6d652f0651a1"),
                            CreatedAt = new DateTime(2023, 2, 12, 17, 21, 22, 207, DateTimeKind.Local).AddTicks(7409),
                            FirstName = "Shohruz",
                            LastName = "Bobobekov",
                            Phone = "+998901033685",
                            TelegramId = 1035640073L,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserRole = 2
                        });
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.ExamApplicant", b =>
                {
                    b.HasOne("BulungurAcademy.Domain.Entities.Exams.Exam", "Exam")
                        .WithMany("ExamApplicants")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BulungurAcademy.Domain.Entities.Subjects.Subject", "FirstSubject")
                        .WithMany()
                        .HasForeignKey("FirstSubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BulungurAcademy.Domain.Entities.Subjects.Subject", "SecondSubject")
                        .WithMany()
                        .HasForeignKey("SecondSubjectId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BulungurAcademy.Domain.Entities.Users.User", "User")
                        .WithMany("ExamApplicants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("FirstSubject");

                    b.Navigation("SecondSubject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.ExamSubjects.ExamSubject", b =>
                {
                    b.HasOne("BulungurAcademy.Domain.Entities.Exams.Exam", "Exam")
                        .WithMany("ExamSubjects")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BulungurAcademy.Domain.Entities.Subjects.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.Exams.Exam", b =>
                {
                    b.Navigation("ExamApplicants");

                    b.Navigation("ExamSubjects");
                });

            modelBuilder.Entity("BulungurAcademy.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("ExamApplicants");
                });
#pragma warning restore 612, 618
        }
    }
}

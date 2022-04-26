﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMSAPI.Models;

#nullable disable

namespace TMSAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TMSAPI.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("AdminId");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("TMSAPI.Models.Assessment", b =>
                {
                    b.Property<int>("AssessmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssessmentID"), 1L, 1);

                    b.Property<string>("AssessmentName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("BatchID")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssessmentID");

                    b.HasIndex("BatchID");

                    b.ToTable("assessments");
                });

            modelBuilder.Entity("TMSAPI.Models.Batch", b =>
                {
                    b.Property<int>("BatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchID"), 1L, 1);

                    b.Property<string>("BatchName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Stream")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainerID")
                        .HasColumnType("int");

                    b.HasKey("BatchID");

                    b.HasIndex("TrainerID");

                    b.ToTable("batch");
                });

            modelBuilder.Entity("TMSAPI.Models.HR", b =>
                {
                    b.Property<int>("HRId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HRId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationQualification")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("HRId");

                    b.ToTable("hr");
                });

            modelBuilder.Entity("TMSAPI.Models.Score", b =>
                {
                    b.Property<int>("ScoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreID"), 1L, 1);

                    b.Property<int>("AssessmentID")
                        .HasColumnType("int");

                    b.Property<int>("GainedScore")
                        .HasColumnType("int");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.Property<int>("TraineeID")
                        .HasColumnType("int");

                    b.HasKey("ScoreID");

                    b.HasIndex("AssessmentID");

                    b.HasIndex("TraineeID");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("TMSAPI.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("BatchID")
                        .HasColumnType("int");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationQualification")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SkillSet")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TraineeID");

                    b.HasIndex("BatchID");

                    b.ToTable("trainees");
                });

            modelBuilder.Entity("TMSAPI.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationQualification")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SkillSet")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TrainerID");

                    b.ToTable("trainers");
                });

            modelBuilder.Entity("TMSAPI.Models.TrainerManager", b =>
                {
                    b.Property<int>("TMID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TMID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationQualification")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TMID");

                    b.ToTable("trainersManager");
                });

            modelBuilder.Entity("TMSClient.Models.Answer", b =>
                {
                    b.Property<int>("AnswerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerID"), 1L, 1);

                    b.Property<string>("AnswerPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AssessmentID")
                        .HasColumnType("int");

                    b.Property<int>("TraineeID")
                        .HasColumnType("int");

                    b.HasKey("AnswerID");

                    b.HasIndex("AssessmentID");

                    b.HasIndex("TraineeID");

                    b.ToTable("answers");
                });

            modelBuilder.Entity("TMSAPI.Models.Assessment", b =>
                {
                    b.HasOne("TMSAPI.Models.Batch", "Batchs")
                        .WithMany()
                        .HasForeignKey("BatchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batchs");
                });

            modelBuilder.Entity("TMSAPI.Models.Batch", b =>
                {
                    b.HasOne("TMSAPI.Models.Trainer", "Trainers")
                        .WithMany()
                        .HasForeignKey("TrainerID");

                    b.Navigation("Trainers");
                });

            modelBuilder.Entity("TMSAPI.Models.Score", b =>
                {
                    b.HasOne("TMSAPI.Models.Assessment", "Assessment")
                        .WithMany()
                        .HasForeignKey("AssessmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMSAPI.Models.Trainee", "Trainee")
                        .WithMany()
                        .HasForeignKey("TraineeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assessment");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("TMSAPI.Models.Trainee", b =>
                {
                    b.HasOne("TMSAPI.Models.Batch", "Batchs")
                        .WithMany()
                        .HasForeignKey("BatchID");

                    b.Navigation("Batchs");
                });

            modelBuilder.Entity("TMSClient.Models.Answer", b =>
                {
                    b.HasOne("TMSAPI.Models.Assessment", "assessment")
                        .WithMany()
                        .HasForeignKey("AssessmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMSAPI.Models.Trainee", "Trainee")
                        .WithMany()
                        .HasForeignKey("TraineeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainee");

                    b.Navigation("assessment");
                });
#pragma warning restore 612, 618
        }
    }
}

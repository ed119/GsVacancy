using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using GsVacancy.DAL.Models;

namespace GsVacancy.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GsVacancy.DAL.Models.Applicant", b =>
                {
                    b.Property<int>("ApplicantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 128);

                    b.Property<int>("RespondId");

                    b.Property<byte[]>("Resume")
                        .HasAnnotation("MaxLength", 1024);

                    b.HasKey("ApplicantId");

                    b.HasAnnotation("Relational:TableName", "Applicants");
                });

            modelBuilder.Entity("GsVacancy.DAL.Models.Respond", b =>
                {
                    b.Property<int>("RespondId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicantId");

                    b.Property<string>("Status");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 128);

                    b.Property<int?>("VacancyVacancyId");

                    b.HasKey("RespondId");

                    b.HasAnnotation("Relational:TableName", "Responds");
                });

            modelBuilder.Entity("GsVacancy.DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .HasAnnotation("MaxLength", 128);

                    b.Property<string>("Password")
                        .HasAnnotation("MaxLength", 128);

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "Users");
                });

            modelBuilder.Entity("GsVacancy.DAL.Models.Vacancy", b =>
                {
                    b.Property<int>("VacancyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasAnnotation("MaxLength", 64);

                    b.Property<DateTime>("CreateDateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime2");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 2083);

                    b.Property<string>("Language");

                    b.Property<string>("Position")
                        .HasAnnotation("MaxLength", 128);

                    b.Property<string>("Requirement")
                        .HasAnnotation("MaxLength", 2083);

                    b.Property<int>("Serial");

                    b.Property<string>("Status");

                    b.HasKey("VacancyId");

                    b.HasAnnotation("Relational:TableName", "Vacancies");
                });

            modelBuilder.Entity("GsVacancy.DAL.Models.Applicant", b =>
                {
                    b.HasOne("GsVacancy.DAL.Models.Respond")
                        .WithOne()
                        .HasForeignKey("GsVacancy.DAL.Models.Applicant", "RespondId");
                });

            modelBuilder.Entity("GsVacancy.DAL.Models.Respond", b =>
                {
                    b.HasOne("GsVacancy.DAL.Models.Vacancy")
                        .WithMany()
                        .HasForeignKey("VacancyVacancyId");
                });
        }
    }
}

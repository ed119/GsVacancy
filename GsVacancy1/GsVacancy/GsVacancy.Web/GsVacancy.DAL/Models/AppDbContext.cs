using System;
using System.Threading.Tasks;

using Microsoft.Data.Entity;

namespace GsVacancy.DAL.Models
{
    public sealed class AppDbContext : DbContext
    {
        #region Overrides of DbContext

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureUsers(modelBuilder);
            ConfigureApplicants(modelBuilder);
            ConfigureVacancies(modelBuilder);
            ConfigureResponds(modelBuilder);
        }

        private static void ConfigureVacancies(ModelBuilder modelBilder)
        {
            modelBilder.Entity<Vacancy>(v => v.ToTable("Vacancies"));
            modelBilder.Entity<Vacancy>().HasKey(v => v.VacancyId);
            modelBilder.Entity<Vacancy>().Property(v => v.City).HasMaxLength(64);
            modelBilder.Entity<Vacancy>().Property(v => v.Description).HasMaxLength(2083); //why -1?
            modelBilder.Entity<Vacancy>().Property(v => v.CreateDateTime).HasColumnType("datetime2");
            modelBilder.Entity<Vacancy>().Property(v => v.Position).HasMaxLength(128);
            modelBilder.Entity<Vacancy>().Property(v => v.Requirement).HasMaxLength(2083);
            modelBilder.Entity<Vacancy>().Property(v => v.Serial).IsRequired();

        }

        private static void ConfigureApplicants(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(a => a.ToTable("Applicants"));
            modelBuilder.Entity<Applicant>().HasKey(a => a.ApplicantId);
            modelBuilder.Entity<Applicant>().Property(a => a.Email).HasMaxLength(128);
            modelBuilder.Entity<Applicant>().Property(a => a.Resume).HasMaxLength(1024); //.HasColumnType("")
        }
        

        private static void ConfigureUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u => u.ToTable("Users"));
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Login).HasMaxLength(128);
            modelBuilder.Entity<User>().Property(u => u.Password).HasMaxLength(128);
        }

        private static void ConfigureResponds(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Respond>(r => r.ToTable("Responds"));
            modelBuilder.Entity<Respond>().HasKey(r => r.RespondId);
            modelBuilder.Entity<Respond>().Property(r => r.Title).HasMaxLength(128);
            modelBuilder.Entity<Respond>().HasOne(a => a.Applicant).WithOne(r => r.Respond);
        }

        #endregion

        public DbSet<User> Users { get; set; }
        public DbSet<Applicant> Applicants { get; set; } 
        public Vacancy Vacancies { get; set; }

        public DbSet<Respond> Responds { get; set; } 

        
    }
}

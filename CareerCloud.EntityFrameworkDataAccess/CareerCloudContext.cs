using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    class CareerCloudContext : DbContext
    {
        public CareerCloudContext() : 
            base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {
                    
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyProfilePoco>()
            .HasMany(c => c.CompanyDescriptions)
            .WithRequired(d => d.CompanyProfiles)
            .HasForeignKey(d => d.Company)
            .WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantEducations).WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant).WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantJobApplications).WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant).WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.ApplicantJobApplications).WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job).WillCascadeOnDelete(true);

            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(c => c.ApplicantProfiles).WithRequired(d => d.SecurityLogins)
                .HasForeignKey(d => d.Login).WillCascadeOnDelete(true);

           

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantResumes).WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant).WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantSkills).WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant).WillCascadeOnDelete(true);

            modelBuilder.Entity<ApplicantProfilePoco>()
                .HasMany(c => c.ApplicantWorkHistories).WithRequired(d => d.ApplicantProfiles)
                .HasForeignKey(d => d.Applicant).WillCascadeOnDelete(true);

            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasMany(c => c.ApplicantWorkHistories).WithRequired(d => d.SystemCountryCodes)
                .HasForeignKey(d => d.CountryCode).WillCascadeOnDelete(true);

            modelBuilder.Entity<SystemLanguageCodePoco>()
                .HasMany(c => c.CompanyDescriptions).WithRequired(d => d.SystemLanguageCodes)
                .HasForeignKey(d => d.LanguageId).WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.CompanyJobEducations).WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job).WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.CompanyJobSkills).WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job).WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyProfilePoco>()
                .HasMany(c => c.CompanyJobs).WithRequired(d => d.CompanyProfiles)
                .HasForeignKey(d => d.Company).WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyJobPoco>()
                .HasMany(c => c.CompanyJobDescriptions).WithRequired(d => d.CompanyJobs)
                .HasForeignKey(d => d.Job).WillCascadeOnDelete(true);

            modelBuilder.Entity<CompanyProfilePoco>()
                .HasMany(c => c.CompanyLocations).WithRequired(d => d.CompanyProfiles)
                .HasForeignKey(d => d.Company).WillCascadeOnDelete(true);

            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(c => c.SecurityLoginsLogs).WithRequired(d => d.SecurityLogins)
                .HasForeignKey(d => d.Login).WillCascadeOnDelete(true);

            modelBuilder.Entity<SecurityLoginPoco>()
                .HasMany(c => c.SecurityLoginsRoles).WithRequired(d => d.SecurityLogins)
                .HasForeignKey(d => d.Login).WillCascadeOnDelete(true);

            modelBuilder.Entity<SecurityRolePoco>()
                .HasMany(c => c.SecurityLoginsRoles).WithRequired(d => d.SecurityRoles)
                .HasForeignKey(d => d.Role).WillCascadeOnDelete(true);
          

            modelBuilder.Entity<SystemCountryCodePoco>()
                .HasMany(c => c.ApplicantProfiles).WithRequired(d => d.SystemCountryCodes)
                .HasForeignKey(d => d.Country).WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
        DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        
        DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        
        
       
    }
}
 
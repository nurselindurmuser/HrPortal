﻿// <auto-generated />
using HrPortal.Data;
using HrPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HrPortal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171117093220_addtag")]
    partial class addtag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HrPortal.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime?>("ApproveDate");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(200);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsEmployer");

                    b.Property<string>("LastName")
                        .HasMaxLength(200);

                    b.Property<string>("LocationId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OccupationId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("OccupationId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HrPortal.Models.Certificate", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertificateFile")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("IssueDate");

                    b.Property<string>("Issuer")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ResumeId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("HrPortal.Models.Company", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<DateTime?>("ApproveDate");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Dribbble")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<int>("EmployeeCount");

                    b.Property<int?>("EstablishYear");

                    b.Property<string>("Facebook")
                        .HasMaxLength(200);

                    b.Property<string>("GitHub")
                        .HasMaxLength(200);

                    b.Property<string>("GooglePlus")
                        .HasMaxLength(200);

                    b.Property<string>("Instagram")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Linkedin")
                        .HasMaxLength(200);

                    b.Property<string>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Phone")
                        .HasMaxLength(200);

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.Property<string>("Pinterest")
                        .HasMaxLength(200);

                    b.Property<string>("SectorId");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(4000);

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.Property<string>("Twitter")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<string>("WebAddress")
                        .HasMaxLength(200);

                    b.Property<string>("YouTube")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SectorId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HrPortal.Models.EducationInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("EducationLevel");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Notes")
                        .HasMaxLength(4000);

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.Property<string>("ResumeId");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime?>("StartDate");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("EducationInfos");
                });

            modelBuilder.Entity("HrPortal.Models.Experience", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<int?>("EndYear");

                    b.Property<string>("Notes")
                        .HasMaxLength(4000);

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ResumeId");

                    b.Property<int>("StartYear");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("HrPortal.Models.Job", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId")
                        .IsRequired();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Details")
                        .IsRequired();

                    b.Property<int?>("EducationLevel");

                    b.Property<DateTime>("EndDate");

                    b.Property<int?>("Experience");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("MilitaryStatus");

                    b.Property<string>("OccupationId");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(4000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<string>("WebAddress")
                        .HasMaxLength(200);

                    b.Property<int?>("WorkingHours");

                    b.Property<int?>("WorkingStyle");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("OccupationId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("HrPortal.Models.JobApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("JobId");

                    b.Property<string>("Message");

                    b.Property<string>("ResumeId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("ResumeId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("HrPortal.Models.JobLocation", b =>
                {
                    b.Property<string>("JobId");

                    b.Property<string>("LocationId");

                    b.HasKey("JobId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("JobLocations");
                });

            modelBuilder.Entity("HrPortal.Models.Language", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("HrPortal.Models.LanguageInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("LanguageId");

                    b.Property<int>("ReadingLevel");

                    b.Property<string>("ResumeId");

                    b.Property<int>("SpeakingLevel");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<int>("WritingLevel");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ResumeId");

                    b.ToTable("LanguageInfos");
                });

            modelBuilder.Entity("HrPortal.Models.Location", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ParentLocationId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ParentLocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HrPortal.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("SenderEmail")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("SenderPhone")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("HrPortal.Models.Occupation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Occupations");
                });

            modelBuilder.Entity("HrPortal.Models.Resume", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ApproveDate");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Dribbble")
                        .HasMaxLength(200);

                    b.Property<string>("DrivingLicense");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Facebook")
                        .HasMaxLength(200);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Github")
                        .HasMaxLength(200);

                    b.Property<string>("GooglePlus")
                        .HasMaxLength(200);

                    b.Property<string>("Hobbies");

                    b.Property<string>("Instagram")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsEncouraged");

                    b.Property<bool>("IsTravelDisabled");

                    b.Property<string>("LanguageId")
                        .IsRequired();

                    b.Property<string>("LinkedIn")
                        .HasMaxLength(200);

                    b.Property<string>("LocationId");

                    b.Property<int>("MilitaryStatus");

                    b.Property<string>("Notes")
                        .HasMaxLength(4000);

                    b.Property<string>("OccupationId");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Photo")
                        .HasMaxLength(200);

                    b.Property<string>("Pinterest")
                        .HasMaxLength(200);

                    b.Property<string>("ResumeFile")
                        .HasMaxLength(200);

                    b.Property<int>("SmokingStatus");

                    b.Property<string>("Tags")
                        .HasMaxLength(4000);

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.Property<string>("Twitter")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<string>("WebAddress")
                        .HasMaxLength(200);

                    b.Property<string>("Youtube")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("LocationId");

                    b.HasIndex("OccupationId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("HrPortal.Models.Sector", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("HrPortal.Models.Setting", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("CustomHtml");

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<string>("Facebook");

                    b.Property<string>("Fax")
                        .HasMaxLength(200);

                    b.Property<string>("FooterText")
                        .HasMaxLength(4000);

                    b.Property<string>("Help");

                    b.Property<string>("HowItWorks");

                    b.Property<string>("Instagram");

                    b.Property<string>("Linkedin");

                    b.Property<string>("MapLat")
                        .HasMaxLength(200);

                    b.Property<string>("MapLng")
                        .HasMaxLength(200);

                    b.Property<string>("MembershipAgreement");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(200);

                    b.Property<string>("MetaTitle")
                        .HasMaxLength(200);

                    b.Property<string>("Phone")
                        .HasMaxLength(200);

                    b.Property<string>("PrivacyPolicy");

                    b.Property<string>("SmtpHost")
                        .HasMaxLength(200);

                    b.Property<string>("SmtpPassword")
                        .HasMaxLength(200);

                    b.Property<string>("SmtpPort")
                        .HasMaxLength(200);

                    b.Property<bool>("SmtpSSLEnabled");

                    b.Property<string>("SmtpUserName")
                        .HasMaxLength(200);

                    b.Property<string>("TermsOfUse");

                    b.Property<string>("Twitter");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<bool>("UseSSL");

                    b.Property<string>("Youtube");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("HrPortal.Models.Skill", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("Level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ResumeId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("HrPortal.Models.Tag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HrPortal.Models.ApplicationUser", b =>
                {
                    b.HasOne("HrPortal.Models.Location", "Location")
                        .WithMany("Users")
                        .HasForeignKey("LocationId");

                    b.HasOne("HrPortal.Models.Occupation", "Occupation")
                        .WithMany("Users")
                        .HasForeignKey("OccupationId");
                });

            modelBuilder.Entity("HrPortal.Models.Certificate", b =>
                {
                    b.HasOne("HrPortal.Models.Resume", "Resume")
                        .WithMany("Certificates")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("HrPortal.Models.Company", b =>
                {
                    b.HasOne("HrPortal.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("HrPortal.Models.Sector", "Sector")
                        .WithMany("Companies")
                        .HasForeignKey("SectorId");
                });

            modelBuilder.Entity("HrPortal.Models.EducationInfo", b =>
                {
                    b.HasOne("HrPortal.Models.Resume", "Resume")
                        .WithMany("EducationInfos")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("HrPortal.Models.Experience", b =>
                {
                    b.HasOne("HrPortal.Models.Resume", "Resume")
                        .WithMany("Experiences")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("HrPortal.Models.Job", b =>
                {
                    b.HasOne("HrPortal.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPortal.Models.Occupation", "Occupation")
                        .WithMany("Jobs")
                        .HasForeignKey("OccupationId");
                });

            modelBuilder.Entity("HrPortal.Models.JobApplication", b =>
                {
                    b.HasOne("HrPortal.Models.Job", "Job")
                        .WithMany("JobApplications")
                        .HasForeignKey("JobId");

                    b.HasOne("HrPortal.Models.Resume", "Resume")
                        .WithMany("JobApplications")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("HrPortal.Models.JobLocation", b =>
                {
                    b.HasOne("HrPortal.Models.Job", "Job")
                        .WithMany("JobLocations")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPortal.Models.Location", "Location")
                        .WithMany("JobLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("HrPortal.Models.LanguageInfo", b =>
                {
                    b.HasOne("HrPortal.Models.Language", "Language")
                        .WithMany("LanguageInfos")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HrPortal.Models.Resume", "Resume")
                        .WithMany("LanguageInfos")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("HrPortal.Models.Location", b =>
                {
                    b.HasOne("HrPortal.Models.Location", "ParentLocation")
                        .WithMany()
                        .HasForeignKey("ParentLocationId");
                });

            modelBuilder.Entity("HrPortal.Models.Resume", b =>
                {
                    b.HasOne("HrPortal.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPortal.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("HrPortal.Models.Occupation", "Occupation")
                        .WithMany("Resumes")
                        .HasForeignKey("OccupationId");
                });

            modelBuilder.Entity("HrPortal.Models.Skill", b =>
                {
                    b.HasOne("HrPortal.Models.Resume", "Resume")
                        .WithMany("Skills")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HrPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HrPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HrPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HrPortal.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

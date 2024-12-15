﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProje.Data;

#nullable disable

namespace WebProje.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231231025135_removeInfoFromWorkingTimes")]
    partial class removeInfoFromWorkingTimes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "sdfjdsklfjs",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "user",
                            ConcurrencyStamp = "fjsahlfkjss",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "doctor",
                            ConcurrencyStamp = "jfdsklfjsad",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "admin"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "admin"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "4",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "5",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "6",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "7",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "8",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "9",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "10",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "11",
                            RoleId = "doctor"
                        },
                        new
                        {
                            UserId = "12",
                            RoleId = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebProje.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorUserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("HospitalClinicId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("DoctorUserId");

                    b.HasIndex("HospitalClinicId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("WebProje.Models.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("WebProje.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int>("SessionTime")
                        .HasColumnType("int");

                    b.Property<int>("SpecialityId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("SpecialityId");

                    b.HasIndex("UserId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("WebProje.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("WebProje.Models.HospitalClinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("HospitalId");

                    b.ToTable("HospitalClinics");
                });

            modelBuilder.Entity("WebProje.Models.HospitalSpecialities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("SpecialityId");

                    b.ToTable("HospitalSpecialities");
                });

            modelBuilder.Entity("WebProje.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("WebProje.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImageName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2c1f3c7b-720b-40a5-afb2-12a19efb6870",
                            Email = "B201210562@sakarya.edu.tr",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "admin",
                            NormalizedUserName = "B201210562@sakarya.edu.tr",
                            PasswordHash = "AQAAAAEAACcQAAAAENnqC+f2o0RyDXqj2SYk4f3snxDZUa9QPM0ikkeBHqYBeZ9GBHLLbrb7JfuAqA1c6Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "769aef18-df61-4ba9-86e0-67c20ada88c6",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "651c3f1b-4da8-4d45-b1d7-1b2c14c4545e",
                            Email = "B201210566@sakarya.edu.tr",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "admin2",
                            NormalizedUserName = "B201210566@sakarya.edu.tr",
                            PasswordHash = "AQAAAAEAACcQAAAAEBZ+sbc4Ijp7eLzYE0ZyNBfM49CDnre+EQJsDhQQP5QZLlqUhIEii5ievXZXAKo5+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9d2c2d6b-c011-4dc8-9af1-44be0a0c670a",
                            TwoFactorEnabled = false,
                            UserName = "admin2"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dcb6e528-891a-4933-a22f-09a01d40d343",
                            Email = "d1@d.com",
                            EmailConfirmed = true,
                            ImageName = "1.jpg",
                            LockoutEnabled = false,
                            Name = "doktor1",
                            NormalizedUserName = "d1@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAECdAKOxdvaMCXSGeSYYUjT32FJjkX4BOAW3ilfTcBdV3TeZAgN1IZtT/6fmZ/m8jgQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "037aa9fb-0310-42dc-97e9-e947494a2ace",
                            TwoFactorEnabled = false,
                            UserName = "d1@d.com"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "727b0573-64cc-494f-874e-ca210bc77a00",
                            Email = "d2@d.com",
                            EmailConfirmed = true,
                            ImageName = "2.jpg",
                            LockoutEnabled = false,
                            Name = "doktor2",
                            NormalizedUserName = "d2@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEFsbQDsXSjnwAXPO6+Ml6I9uCp+pIfVsLCgMauYsjQuZh5y/illcAx+xcH6R3Rk/iw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "56b72165-77cf-41e5-b629-e84e826122db",
                            TwoFactorEnabled = false,
                            UserName = "d2@d.com"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dcc8b0ac-72c2-4475-8e16-84c0830c90d5",
                            Email = "d3@d.com",
                            EmailConfirmed = true,
                            ImageName = "3.jpg",
                            LockoutEnabled = false,
                            Name = "doktor3",
                            NormalizedUserName = "d3@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEGsUT8iMm7fqgCrxP766Vkcpkb0McHWm8rsC0KYiTGXtuAqQr/K7tbkgX6kOqv/n/A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0ddc704d-bd49-4da1-bb9a-24beade1f3bb",
                            TwoFactorEnabled = false,
                            UserName = "d3@d.com"
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3592d201-0e97-4211-ba01-ca9a71c8f4cc",
                            Email = "d4@d.com",
                            EmailConfirmed = true,
                            ImageName = "4.jpg",
                            LockoutEnabled = false,
                            Name = "doktor4",
                            NormalizedUserName = "d4@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEJiH3LJcUzjMYDUPKPMWUksfTEmEVQFSheFmeoyRDX1MAlAPOrkgNndeUFbji77Yjw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4510909a-b9e4-4cee-b174-6e523f189636",
                            TwoFactorEnabled = false,
                            UserName = "d4@d.com"
                        },
                        new
                        {
                            Id = "7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4f95eb19-6c65-4c53-9450-e1cf32601dbf",
                            Email = "d5@d.com",
                            EmailConfirmed = true,
                            ImageName = "5.jpg",
                            LockoutEnabled = false,
                            Name = "doktor5",
                            NormalizedUserName = "d5@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEM/rSU+NQVF6nCx211ToN0+fIMR2ZtNBUQdLNgCw0uopu80GWD9l3nffyC50ydADRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "78ccf8bd-f776-4104-a779-28844753f0d1",
                            TwoFactorEnabled = false,
                            UserName = "d5@d.com"
                        },
                        new
                        {
                            Id = "8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "58c12ac4-46f2-4741-9bb6-d802991f5e77",
                            Email = "d6@d.com",
                            EmailConfirmed = true,
                            ImageName = "6.jpg",
                            LockoutEnabled = false,
                            Name = "doktor6",
                            NormalizedUserName = "d6@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEAYfCKP00cUiqkAeJTuvh9bzdQwyr6jYuIywxm+/j38wCYFvswPRlAPdYuYu09sI6A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "217990ef-99d3-47d4-8fa3-f304fecde913",
                            TwoFactorEnabled = false,
                            UserName = "d6@d.com"
                        },
                        new
                        {
                            Id = "9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2da79382-cc32-443d-879e-f2b432441d60",
                            Email = "d7@d.com",
                            EmailConfirmed = true,
                            ImageName = "7.jpg",
                            LockoutEnabled = false,
                            Name = "doktor7",
                            NormalizedUserName = "d7@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEIMch0Jr4qigrmhCJg5KAQdcyZq/gtLwxX2kaZyblsIl4KFlmDS6EjmMm9JhxhGoZA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cb2a89b7-cf2d-4e46-8eec-3cdffed9b593",
                            TwoFactorEnabled = false,
                            UserName = "d7@d.com"
                        },
                        new
                        {
                            Id = "10",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "db290948-709e-40dc-8a0c-332fa0025543",
                            Email = "d8@d.com",
                            EmailConfirmed = true,
                            ImageName = "8.jpg",
                            LockoutEnabled = false,
                            Name = "doktor8",
                            NormalizedUserName = "d8@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEwYQDqANqXNkal5Kq78QA4Crv4IN6+Z0jmMcfnsnROUJH5WoFoe+2QYOfswuALR+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0685a708-4158-4b58-9b1f-7811349a8633",
                            TwoFactorEnabled = false,
                            UserName = "d8@d.com"
                        },
                        new
                        {
                            Id = "11",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4062dccb-ce83-4d81-bd96-05e943bbcd39",
                            Email = "d9@d.com",
                            EmailConfirmed = true,
                            ImageName = "9.jpg",
                            LockoutEnabled = false,
                            Name = "doktor9",
                            NormalizedUserName = "d9@d.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEAVcECy7htLwdE4Jif3dBLXIFXTXOQcCC+d8vxB7TL3T5dwK/uQY8mjuvhVLC54kgw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4109e6f9-d758-4ef2-aeeb-8381544e346f",
                            TwoFactorEnabled = false,
                            UserName = "d9@d.com"
                        },
                        new
                        {
                            Id = "12",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "75678aae-84bf-4266-bacf-b99819250d13",
                            Email = "u1@u.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "user1",
                            NormalizedUserName = "u1@u.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEJuDX2w9eMJllWT+O4o4sVnLqh/vdyViZIpb4JvnjiGASFk/3CjWSVB8RfLBRKGaig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3dbfe0dc-a50d-482c-98bc-f23a9c732daf",
                            TwoFactorEnabled = false,
                            UserName = "u1@u.com"
                        });
                });

            modelBuilder.Entity("WebProje.Models.WorkingTimes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DaysOfWeek")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EndTime")
                        .HasColumnType("int");

                    b.Property<int>("StartTime")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WorkingTimes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebProje.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebProje.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebProje.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProje.Models.Appointment", b =>
                {
                    b.HasOne("WebProje.Models.Doctor", null)
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("WebProje.Models.User", "DoctorUser")
                        .WithMany()
                        .HasForeignKey("DoctorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.HospitalClinic", "HospitalClinic")
                        .WithMany()
                        .HasForeignKey("HospitalClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoctorUser");

                    b.Navigation("HospitalClinic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebProje.Models.Clinic", b =>
                {
                    b.HasOne("WebProje.Models.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("WebProje.Models.Doctor", b =>
                {
                    b.HasOne("WebProje.Models.Clinic", "Clinic")
                        .WithMany()
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Hospital", "Hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.User", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Hospital");

                    b.Navigation("Speciality");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("WebProje.Models.HospitalClinic", b =>
                {
                    b.HasOne("WebProje.Models.Clinic", "Clinic")
                        .WithMany()
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("WebProje.Models.HospitalSpecialities", b =>
                {
                    b.HasOne("WebProje.Models.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("WebProje.Models.WorkingTimes", b =>
                {
                    b.HasOne("WebProje.Models.User", "User")
                        .WithMany("WorkingTimes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebProje.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("WebProje.Models.Hospital", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("WebProje.Models.User", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("WorkingTimes");
                });
#pragma warning restore 612, 618
        }
    }
}

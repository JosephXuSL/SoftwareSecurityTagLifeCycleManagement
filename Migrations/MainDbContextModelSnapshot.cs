﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSTLifeCycleManagement.DbContexts;

#nullable disable

namespace SSTLifeCycleManagement.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("Birthday");

                    b.Property<string>("EmployeeStatus")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("EmployeeStatus");

                    b.Property<string>("Gen")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Gen");

                    b.Property<string>("JobNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("JobNumber");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.AdminAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("AccountName");

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("AccountStatus");

                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("AdminId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.HasIndex("AdminId")
                        .IsUnique();

                    b.ToTable("AdminAccount", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("CountryCd");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("CountryName");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Address");

                    b.Property<string>("BusinessCertificate")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar")
                        .HasColumnName("BusinessCertificate");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Developer", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryCd")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Country");

                    b.Property<int>("CountryCode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("CountryCd");

                    b.ToTable("People", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.RoleAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AdminPermission")
                        .HasColumnType("bit")
                        .HasColumnName("AdminPermission");

                    b.Property<int>("DeveloperId")
                        .HasColumnType("int")
                        .HasColumnName("DeveloperId");

                    b.Property<bool>("ReadPermission")
                        .HasColumnType("bit")
                        .HasColumnName("ReadPermission");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar")
                        .HasColumnName("RoleName");

                    b.Property<bool>("WritePermission")
                        .HasColumnType("bit")
                        .HasColumnName("WritePermission");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.ToTable("RoleAccess", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.SecurityTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("AppId");

                    b.Property<string>("AppName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("AppName");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("CreateTime");

                    b.Property<DateTime>("DevelopTime")
                        .HasColumnType("datetime")
                        .HasColumnName("DevelopTime");

                    b.Property<int>("DeveloperId")
                        .HasColumnType("int")
                        .HasColumnName("DeveloperId");

                    b.Property<int>("MaxUsers")
                        .HasColumnType("int")
                        .HasColumnName("MaxUsers");

                    b.Property<string>("Memory")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Memory");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("nvarchar")
                        .HasColumnName("Signature");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Status");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Version");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.ToTable("SecurityTag", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeveloperId")
                        .HasColumnType("int")
                        .HasColumnName("DeveloperId");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Email");

                    b.Property<string>("Gen")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Gen");

                    b.Property<string>("IdentityCardNumber")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar")
                        .HasColumnName("IdentityCardNumber");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("UserStatus")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("UserStatus");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("AccountName");

                    b.Property<string>("AccountStatus")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("AccountStatus");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Password");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserAccount", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    b.Property<int>("TagId")
                        .HasColumnType("int")
                        .HasColumnName("SecurityTagId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TagId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.AdminAccount", b =>
                {
                    b.HasOne("SSTLifeCycleManagement.Entities.Admin", "Admin")
                        .WithOne()
                        .HasForeignKey("SSTLifeCycleManagement.Entities.AdminAccount", "AdminId")
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.People", b =>
                {
                    b.HasOne("SSTLifeCycleManagement.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryCd")
                        .HasPrincipalKey("CountryCode")
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.RoleAccess", b =>
                {
                    b.HasOne("SSTLifeCycleManagement.Entities.Developer", null)
                        .WithMany()
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.SecurityTag", b =>
                {
                    b.HasOne("SSTLifeCycleManagement.Entities.Developer", "Developer")
                        .WithMany()
                        .HasForeignKey("DeveloperId")
                        .IsRequired();

                    b.Navigation("Developer");
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.User", b =>
                {
                    b.HasOne("SSTLifeCycleManagement.Entities.Developer", "Developer")
                        .WithMany()
                        .HasForeignKey("DeveloperId")
                        .IsRequired();

                    b.Navigation("Developer");
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.UserAccount", b =>
                {
                    b.HasOne("SSTLifeCycleManagement.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("SSTLifeCycleManagement.Entities.UserAccount", "UserId")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SSTLifeCycleManagement.Entities.UserRole", b =>
                {
                    b.HasOne("SSTLifeCycleManagement.Entities.RoleAccess", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .IsRequired();

                    b.HasOne("SSTLifeCycleManagement.Entities.SecurityTag", "APPSecurityTag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .IsRequired();

                    b.HasOne("SSTLifeCycleManagement.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired();

                    b.Navigation("APPSecurityTag");

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CRUDOperation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDOperation.Migrations
{
    [DbContext(typeof(EmployeeAPIDbContext))]
    partial class EmployeeAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUDOperation.Models.Employee", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeId"));

                    b.Property<string>("employeeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employeeSalary")
                        .HasColumnType("int");

                    b.HasKey("employeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CRUDOperation.Models.EmployeeAttendance", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("attendanceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.Property<bool>("isAbsent")
                        .HasColumnType("bit");

                    b.Property<bool>("isOffday")
                        .HasColumnType("bit");

                    b.Property<bool>("isPresent")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("employeeId");

                    b.ToTable("EmployeeAttendances");
                });

            modelBuilder.Entity("CRUDOperation.Models.EmployeeAttendance", b =>
                {
                    b.HasOne("CRUDOperation.Models.Employee", "Employee")
                        .WithMany("EmployeeAttendances")
                        .HasForeignKey("employeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CRUDOperation.Models.Employee", b =>
                {
                    b.Navigation("EmployeeAttendances");
                });
#pragma warning restore 612, 618
        }
    }
}

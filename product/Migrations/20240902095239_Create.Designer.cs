﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using product.Models;

#nullable disable

namespace product.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20240902095239_Create")]
    partial class Create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("product.Models.Employeecs", b =>
                {
                    b.Property<int>("empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empid"));

                    b.Property<string>("depname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("empsalary")
                        .HasColumnType("float");

                    b.HasKey("empid");

                    b.ToTable("Employee1");
                });
#pragma warning restore 612, 618
        }
    }
}

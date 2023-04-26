﻿// <auto-generated />
using System;
using CodeHomeWork_4_3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeHomeWork_4_3.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClientId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfRegistration = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example1@gmail.com",
                            Name = "Example 1.4",
                            Phone = 11111111
                        },
                        new
                        {
                            Id = 2,
                            DateOfRegistration = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example2@gmail.com",
                            Name = "Example 2.4",
                            Phone = 22222222
                        },
                        new
                        {
                            Id = 3,
                            DateOfRegistration = new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example3@gmail.com",
                            Name = "Example 3.4",
                            Phone = 33333333
                        },
                        new
                        {
                            Id = 4,
                            DateOfRegistration = new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example4@gmail.com",
                            Name = "Example41.4",
                            Phone = 44444444
                        },
                        new
                        {
                            Id = 5,
                            DateOfRegistration = new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example5@gmail.com",
                            Name = "Example 5.4",
                            Phone = 55555555
                        });
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<DateTime>("HiredDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2")
                        .HasColumnName("HiredDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LastName");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Andriy",
                            HiredDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "A",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            HiredDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "J",
                            OfficeId = 2,
                            TitleId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2000, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Svetlana",
                            HiredDate = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "S",
                            OfficeId = 3,
                            TitleId = 3
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(2000, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Vanya",
                            HiredDate = new DateTime(2022, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "V",
                            OfficeId = 4,
                            TitleId = 4
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lena",
                            HiredDate = new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "L",
                            OfficeId = 5,
                            TitleId = 5
                        });
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.EmployeeProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeProjectId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2")
                        .HasColumnName("StartedDate");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 1000m,
                            StartedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            ProjectId = 2,
                            Rate = 2000m,
                            StartedDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 3,
                            ProjectId = 3,
                            Rate = 3000m,
                            StartedDate = new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 4,
                            ProjectId = 4,
                            Rate = 4000m,
                            StartedDate = new DateTime(2020, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 5,
                            ProjectId = 5,
                            Rate = 5000m,
                            StartedDate = new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OfficeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Location");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Office", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Example 1.1",
                            Title = "Example 1"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Example 2.1",
                            Title = "Example 2"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Example 3.1",
                            Title = "Example 3"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Example 4.1",
                            Title = "Example 4"
                        },
                        new
                        {
                            Id = 5,
                            Location = "Example 5.1",
                            Title = "Example 5"
                        });
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProjectId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2")
                        .HasColumnName("StartedDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Project", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 1000m,
                            ClientId = 1,
                            Name = "Example 1.3",
                            StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Budget = 2000m,
                            ClientId = 2,
                            Name = "Example 2.3",
                            StartedDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Budget = 3000m,
                            ClientId = 3,
                            Name = "Example 3.3",
                            StartedDate = new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Budget = 4000m,
                            ClientId = 4,
                            Name = "Example 4.3",
                            StartedDate = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Budget = 5000m,
                            ClientId = 5,
                            Name = "Example 5.3",
                            StartedDate = new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TitleId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Title", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Example 1.2"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Example 2.2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Example 3.2"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Example 4.2"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Example 5.2"
                        });
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Employee", b =>
                {
                    b.HasOne("CodeHomeWork_4_3.DB_Models.Office", "Offices")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeHomeWork_4_3.DB_Models.Title", "Titles")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offices");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.EmployeeProject", b =>
                {
                    b.HasOne("CodeHomeWork_4_3.DB_Models.Employee", "Employees")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeHomeWork_4_3.DB_Models.Project", "Projects")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Project", b =>
                {
                    b.HasOne("CodeHomeWork_4_3.DB_Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("CodeHomeWork_4_3.DB_Models.Title", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using CodeHomeWork_4_3.DB_Models;

namespace CodeHomeWork_4_3.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
               .ToTable("Employee")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeId");

            builder
                .Property(c => c.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(50);

            builder
                .Property(c => c.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(50);

            builder
                .Property(c => c.HiredDate)
                .HasColumnName("HiredDate")
                .HasMaxLength(7);
            
            builder
                .HasOne(b => b.Titles)
                .WithMany(x => x.Employees)
                .HasForeignKey(k => k.TitleId);

            builder
                .HasOne(b => b.Offices)
                .WithMany(x => x.Employees)
                .HasForeignKey(k => k.OfficeId);

            builder
                .HasData(

                new Employee
                {
                    Id = 1,
                    FirstName = "Andriy",
                    LastName = "A",
                    HiredDate = new DateTime(2022, 1, 1),
                    DateOfBirth = new DateTime(2000, 1, 1),
                    OfficeId = 1,
                    TitleId = 1
                },

                new Employee
                {
                    Id = 2,
                    FirstName = "John",
                    LastName = "J",
                    HiredDate = new DateTime(2022, 2, 2),
                    DateOfBirth = new DateTime(2000, 2, 2),
                    OfficeId = 2,
                    TitleId = 2
                },

                new Employee
                {
                    Id = 3,
                    FirstName = "Svetlana",
                    LastName = "S",
                    HiredDate = new DateTime(2022, 3, 3),
                    DateOfBirth = new DateTime(2000, 3, 3),
                    OfficeId = 3,
                    TitleId = 3
                },

                new Employee
                {
                    Id = 4,
                    FirstName = "Vanya",
                    LastName = "V",
                    HiredDate = new DateTime(2022, 4, 4),
                    DateOfBirth = new DateTime(2000, 4, 4),
                    OfficeId = 4,
                    TitleId = 4
                },

                new Employee
                {
                    Id = 5,
                    FirstName = "Lena",
                    LastName = "L",
                    HiredDate = new DateTime(2022, 5, 5),
                    DateOfBirth = new DateTime(2000, 5, 5),
                    OfficeId = 5,
                    TitleId = 5
                });
        }
    }
}

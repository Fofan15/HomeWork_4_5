using CodeHomeWork_4_3.DB_Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_3.Configurations
{
    internal class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeProjectId");

            builder
               .Property(c => c.StartedDate)
               .HasColumnName("StartedDate")
               .HasMaxLength(7);

            builder.HasData(

               new EmployeeProject
               {
                   Id = 1,
                   Rate = 1000,
                   StartedDate = new DateTime(2020, 1, 1),
                   EmployeeId = 1,
                   ProjectId = 1
               },

               new EmployeeProject
               {
                   Id = 2,
                   Rate = 2000,
                   StartedDate = new DateTime(2020, 2, 2),
                   EmployeeId = 2,
                   ProjectId = 2
               },

               new EmployeeProject
               {
                   Id = 3,
                   Rate = 3000,
                   StartedDate = new DateTime(2020, 3, 3),
                   EmployeeId = 3,
                   ProjectId = 3
               },

               new EmployeeProject
               {
                   Id = 4,
                   Rate = 4000,
                   StartedDate = new DateTime(2020, 4, 4),
                   EmployeeId = 4,
                   ProjectId = 4
               },

               new EmployeeProject
               {
                   Id = 5,
                   Rate = 5000,
                   StartedDate = new DateTime(2020, 5, 5),
                   EmployeeId = 5,
                   ProjectId = 5
               }
               );
        }
    }
}

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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
               .ToTable("Project")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("ProjectId");

            builder
                .Property(c => c.Name)
                .HasColumnName("Name")
                .HasMaxLength(50);

            builder
                .Property(c => c.StartedDate)
                .HasColumnName("StartedDate")
                .HasMaxLength(7);

            builder
                .HasOne(p => p.Client)
                .WithMany(d => d.Projects)
                .HasForeignKey(d => d.ClientId)
                .IsRequired();

            builder
                .HasData(

                new Project
                {
                    Id = 1,
                    Name = "Example 1.3",
                    Budget = 1000,
                    StartedDate = new DateTime(2021, 1, 1),
                    ClientId = 1
                },

                new Project
                {
                    Id = 2,
                    Name = "Example 2.3",
                    Budget = 2000,
                    StartedDate = new DateTime(2021, 2, 2),
                    ClientId = 2
                },

                new Project
                {
                    Id = 3,
                    Name = "Example 3.3",
                    Budget = 3000,
                    StartedDate = new DateTime(2021, 3, 3),
                    ClientId = 3
                },

                new Project
                {
                    Id = 4,
                    Name = "Example 4.3",
                    Budget = 4000,
                    StartedDate = new DateTime(2021, 4, 4),
                    ClientId = 4
                },

                new Project
                {
                    Id = 5,
                    Name = "Example 5.3",
                    Budget = 5000,
                    StartedDate = new DateTime(2021, 5, 5),
                    ClientId = 5
                }
                );
        }
    }
}

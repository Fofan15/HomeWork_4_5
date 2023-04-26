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
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
               .ToTable("Office")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("OfficeId");

            builder
                .Property(c => c.Title)
                .HasColumnName("Title")
                .HasMaxLength(100);

            builder
                 .Property(c => c.Location)
                 .HasColumnName("Location")
                 .HasMaxLength(100);

            builder
                .HasData(

                new Office
                {
                    Id = 1,
                    Title = "Example 1",
                    Location = "Example 1.1"
                },

                new Office
                {
                    Id = 2,
                    Title = "Example 2",
                    Location = "Example 2.1"
                },

                new Office
                {
                    Id = 3,
                    Title = "Example 3",
                    Location = "Example 3.1"
                },

                new Office
                {
                    Id = 4,
                    Title = "Example 4",
                    Location = "Example 4.1"
                },

                new Office
                {
                    Id = 5,
                    Title = "Example 5",
                    Location = "Example 5.1"
                }
                );
        }
    }
}

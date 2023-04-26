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
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
               .ToTable("Title")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("TitleId");

            builder
                .Property(c => c.Name)
                .HasColumnName("Name")
                .HasMaxLength(50);

            builder.HasData(

                new Title
                {
                    Id = 1,
                    Name = "Example 1.2"
                },

                new Title
                {
                    Id = 2,
                    Name = "Example 2.2"
                },

                new Title
                {
                    Id = 3,
                    Name = "Example 3.2"
                },

                new Title
                {
                    Id = 4,
                    Name = "Example 4.2"
                },

                new Title
                {
                    Id = 5,
                    Name = "Example 5.2"
                }
                );
        }
    }
}

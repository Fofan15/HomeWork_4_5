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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
               .ToTable("Client")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("ClientId");

            builder
                .Property(e => e.Name)
                .HasMaxLength(50);

            builder
                .HasData(

                new Client
                {
                    Id = 1,
                    Name = "Example 1.4",
                    DateOfRegistration = new DateTime(2023, 1, 1),
                    Phone = 11111111,
                    Email = "example1@gmail.com"
                },

                new Client
                {
                    Id = 2,
                    Name = "Example 2.4",
                    DateOfRegistration = new DateTime(2023, 2, 2),
                    Phone = 22222222,
                    Email = "example2@gmail.com"
                },

                new Client
                {
                    Id = 3,
                    Name = "Example 3.4",
                    DateOfRegistration = new DateTime(2023, 3, 3),
                    Phone = 33333333,
                    Email = "example3@gmail.com"
                },

                new Client
                {
                    Id = 4,
                    Name = "Example41.4",
                    DateOfRegistration = new DateTime(2023, 4, 4),
                    Phone = 44444444,
                    Email = "example4@gmail.com"
                },

                new Client
                {
                    Id = 5,
                    Name = "Example 5.4",
                    DateOfRegistration = new DateTime(2023, 5, 5),
                    Phone = 55555555,
                    Email = "example5@gmail.com"
                }
                );
        }
    }
}


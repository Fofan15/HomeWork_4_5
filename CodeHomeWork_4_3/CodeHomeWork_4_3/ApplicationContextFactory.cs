using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CodeHomeWork_4_3
{
    public class MyConnectionString
    {
        public string ConnectionString { get; set; }
    }

    public sealed class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            string jsonString = File.ReadAllText("MyConnectionString.json");
            MyConnectionString myConnectionString = JsonSerializer.Deserialize<MyConnectionString>(jsonString);

            var connectionString = myConnectionString.ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString)
                .Options;

            return new ApplicationContext(options);
        }
    }
}

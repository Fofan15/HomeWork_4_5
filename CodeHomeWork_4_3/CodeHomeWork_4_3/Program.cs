using CodeHomeWork_4_3.DB_Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Xml.Linq;

namespace CodeHomeWork_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                context.Database.EnsureCreated();

                var transaction = context.Database.BeginTransaction();

                try
                {
                    //1
                    context.EmployeeProjects
                        .Include(i => i.Projects)
                        .Include(i => i.Employees)
                        .ToList();

                    //2
                    context.Employees
                        .Select(i => new
                        {
                            id = i.Id,
                            days = EF.Functions.DateDiffDay(i.HiredDate, DateTime.UtcNow)
                        })
                        .ToList();

                    //3
                    var name1 = context.Employees.Find(1);
                    var name2 = context.Employees.Find(1);

                    name1.FirstName = "Sasha";
                    name2.FirstName = "Tanya";

                    context.SaveChanges();
                    transaction.Commit();

                    //4
                    var empl = new Employee
                    {
                        Id = 6,
                        FirstName = "Nazar",
                        LastName = "5",
                        HiredDate = new DateTime(2021, 6, 6),
                        DateOfBirth = new DateTime(2000, 6, 6),
                        OfficeId = 6,
                        TitleId = 6
                    };

                    context.Employees.Add(empl);
                    context.SaveChanges();

                    //5
                    var empl1 = context.Employees.Find(1);
                    context.Employees.Remove(empl1);
                    context.SaveChanges();

                    //6
                    var empl2 = context.Employees.Where(i => EF.Functions.Like(i.Titles.Name, "%a%")).GroupBy(i => i.TitleId);
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }

            }
        }
    }
}
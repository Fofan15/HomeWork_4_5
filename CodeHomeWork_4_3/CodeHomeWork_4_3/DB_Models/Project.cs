using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_3.DB_Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? Budget { get; set; }

        public DateTime StartedDate { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}

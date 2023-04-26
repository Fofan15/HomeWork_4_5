using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_3.DB_Models
{
    public class EmployeeProject
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employees { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Projects { get; set; }

        public decimal Rate { get; set; }

        public DateTime StartedDate { get; set; }
    }
}

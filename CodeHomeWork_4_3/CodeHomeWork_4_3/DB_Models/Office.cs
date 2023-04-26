using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_3.DB_Models
{
    public class Office
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}

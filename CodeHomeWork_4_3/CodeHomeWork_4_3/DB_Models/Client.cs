using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_3.DB_Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public virtual List<Project> Projects { get; set; }
    }
}

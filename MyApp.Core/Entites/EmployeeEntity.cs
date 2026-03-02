using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entites
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Email { get; set; } = null;
        public double Salary { get; set; }
        public string PhoneNumber { get; set; } = null;
    }
}

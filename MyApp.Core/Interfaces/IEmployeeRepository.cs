using MyApp.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<EmployeeEntity> AddEmployeeAsync(object employee);
        Task<IEnumerable<EmployeeEntity>> GetAllEmployees();
    }
}

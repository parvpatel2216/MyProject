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
        Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee);
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
        Task<EmployeeEntity> GetEmployeeByIdAsync(int id);
        Task<EmployeeEntity> UpdateEmployeeAsync(int employeeId, EmployeeEntity entity);
        Task<bool> DeleteEmployeeAsync(int employeeId);
    }
}

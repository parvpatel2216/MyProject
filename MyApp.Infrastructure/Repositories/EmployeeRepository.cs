using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entites;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;

namespace MyApp.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext dbContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeByIdAsync(int id)
        {
            return await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entity)
        {
            dbContext.Employees.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(int employeeId, EmployeeEntity entity)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employee is not null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.Salary = entity.Salary;
                employee.PhoneNumber = entity.PhoneNumber;
                await dbContext.SaveChangesAsync();
            return employee;
            }
            return entity;
        }

        public async Task<bool> DeleteEmployeeAsync(int employeeId)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employee is not null)
            {
                
                dbContext.Employees.Remove(employee);
                return await dbContext.SaveChangesAsync() > 0;
            }
            return false;
        }

        public Task<EmployeeEntity> GetEmployeeByIdAsync(Guid employeeId)
        {
            throw new NotImplementedException();
        }
    }
}

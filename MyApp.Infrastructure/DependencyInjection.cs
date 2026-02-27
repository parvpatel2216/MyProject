using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-L2UK954\\MSSQLSERVER01;Database=TestAPIDb;Trustd_Connection=True;TrustServerCertificate=true;MultipleActiveResults=true");
            });
            
            services.AddScoped<IEmployeeRepository, EmployeeRepositoy>();
            return services;
        }
    }
}

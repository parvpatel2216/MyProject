using MediatR;
using MyApp.Core.Entites;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record UpdateEmployeeCommand( int EmployeeId, EmployeeEntity Employee) : IRequest<EmployeeEntity>;


    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellation)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.EmployeeId, request.Employee);
        }
    }
}

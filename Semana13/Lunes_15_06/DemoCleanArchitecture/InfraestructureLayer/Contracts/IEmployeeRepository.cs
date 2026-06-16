using DomainLayer.Entities;
using InfraestructureLayer.Dto;

namespace InfraestructureLayer.Contracts
{
    public interface IEmployeeRepository
    {
        Task<ServiceResponse> AddAsync(Employee employee);
        Task<ServiceResponse> UpdateAsync(Employee employee);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<List<Employee>> GetByIdAsync(int id);
        Task<Employee> GetALLAsync();
    }
}

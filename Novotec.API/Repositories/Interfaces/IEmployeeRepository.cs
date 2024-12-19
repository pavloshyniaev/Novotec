using Novotec.API.Dto;
using NovotecDB.Models;

namespace Novotec.API.Interfaces;

public interface IEmployeeRepository
{
    Task<SynchronizedEmployeesDto> SynchronizeEmployees(List<PersonDto> employees);
    Task<(List<PersonDto>, List<PersonDto>)> AddOrUpdate(List<PersonDto> employees);
    Task<List<PersonDto>> GetEmployees(List<long>? employeeIds = null);
}
using Novotec.API.Dto;
using NovotecDB.Models;

namespace Novotec.API.Interfaces;

public interface IEmployeeRepository
{
    Task SynchronizeEmployees(List<PersonDto> employees);
    Task AddOrUpdate(List<PersonDto> employees);
    Task<List<PersonDto>> GetEmployees();
}
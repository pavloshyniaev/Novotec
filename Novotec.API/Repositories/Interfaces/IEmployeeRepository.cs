using Novotec.API.Dto;
using NovotecDB.Models;

namespace Novotec.API.Interfaces;

public interface IEmployeeRepository
{
    Task AddOrUpdate(List<PersonDto> employees);
    Task<List<PersonDto>> GetEmployees();
}
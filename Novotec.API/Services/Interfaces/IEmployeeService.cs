using Novotec.API.Dto;

namespace Novotec.API.Interfaces;

public interface IEmployeeService
{
    Task Synchronize();
    Task AddOrUpdate(List<PersonDto> employees);
    Task<List<PersonDto>> Get();
}
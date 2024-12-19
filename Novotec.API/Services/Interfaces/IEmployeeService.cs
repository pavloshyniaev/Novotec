using Novotec.API.Dto;

namespace Novotec.API.Interfaces;

public interface IEmployeeService
{
    Task<SynchronizedEmployeesDto> Synchronize(bool onlyUpdate);
    Task<SynchronizedEmployeesDto> AddOrUpdate(List<PersonDto> employees);
    Task<List<PersonDto>> Get();
}
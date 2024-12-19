using Novotec.API.Dto;
using Novotec.API.Interfaces;

namespace Novotec.API.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IApiService _apiService;

    public EmployeeService(IEmployeeRepository employeeRepository, IApiService apiService)
    {
        _employeeRepository = employeeRepository;
        _apiService = apiService;
    }

    public async Task<SynchronizedEmployeesDto> Synchronize(bool onlyUpdate)
    {
        var employees = await _apiService.FetchData<List<PersonDto>>("/tank-station/persons");
        if (employees == null)
        {
            throw new ArgumentNullException("Employees not found");
        }
        return await _employeeRepository.SynchronizeEmployees(employees, onlyUpdate);
    }

    public async Task<SynchronizedEmployeesDto> AddOrUpdate(List<PersonDto> employees)
    {
        var synchronizedEmployees = await _employeeRepository.AddOrUpdate(employees, true);
        return new SynchronizedEmployeesDto(synchronizedEmployees.Item1, synchronizedEmployees.Item2, new List<PersonDto>());
    }

    public async Task<List<PersonDto>> Get()
    {
        return await _employeeRepository.GetEmployees();
    }
}
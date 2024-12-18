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

    public async Task Synchronize()
    {
        var employees = await _apiService.FetchData<List<PersonDto>>("/tank-station/persons");
        if (employees == null)
        {
            throw new ArgumentNullException("Employees not found");
        }
        await _employeeRepository.SynchronizeEmployees(employees);
    }

    public Task AddOrUpdate(List<PersonDto> employees)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PersonDto>> Get()
    {
        return await _employeeRepository.GetEmployees();
    }
}
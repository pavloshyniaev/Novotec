using Microsoft.AspNetCore.Mvc;
using Novotec.API.Interfaces;
using NovotecDB.Models;

namespace Novotec.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;
    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpPost]
    [Route("addOrUpdate")]
    public async Task<IActionResult> AddOrUpdate(List<Employee> employees)
    {
        try
        {
            await _employeeRepository.AddOrUpdate(employees);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
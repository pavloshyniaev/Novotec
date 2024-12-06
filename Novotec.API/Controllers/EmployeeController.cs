using Microsoft.AspNetCore.Mvc;
using Novotec.API.Dto;
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
    public async Task<IActionResult> AddOrUpdate([FromBody] List<PersonDto> employees)
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
    [HttpGet]
    public async Task<IActionResult> GetEmployees()
    {
        try
        {
            var employees = await _employeeRepository.GetEmployees();
            return Ok(employees);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
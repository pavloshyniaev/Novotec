using Microsoft.AspNetCore.Mvc;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using NovotecDB.Models;

namespace Novotec.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    [Route("fullSynchronize")]
    public async Task<IActionResult> FullSynchronize()
    {
        try
        {
            var synchronizedEmployeesLists = await _employeeService.Synchronize(false);
            return Ok(synchronizedEmployeesLists);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost]
    [Route("partialSynchronize")]
    public async Task<IActionResult> PartialSynchronize()
    {
        try
        {
            var synchronizedEmployeesLists = await _employeeService.Synchronize(true);
            return Ok(synchronizedEmployeesLists);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost]
    [Route("addOrUpdate")]
    public async Task<IActionResult> AddOrUpdate(List<PersonDto> employees)
    {
        try
        {
            await _employeeService.AddOrUpdate(employees);
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
            var employees = await _employeeService.Get();
            return Ok(employees);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
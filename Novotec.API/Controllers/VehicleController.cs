using Microsoft.AspNetCore.Mvc;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using NovotecDB.Models;

namespace Novotec.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleRepository _vehicleRepository;
    public VehicleController(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    [HttpPost]
    [Route("addOrUpdate")]
    public async Task<IActionResult> AddOrUpdate(List<VehicleDto> vehicles)
    {
        try
        {
            await _vehicleRepository.AddOrUpdate(vehicles);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetVehicles()
    {
        try
        {
            await _vehicleRepository.GetVehicles();
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using NovotecDB.Models;

namespace Novotec.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleService _vehicleService;

    public VehicleController(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    [HttpPost]
    [Route("fullSynchronize")]
    public async Task<IActionResult> FullSynchronize()
    {
        try
        {
            var synchronizedVehicles = await _vehicleService.Synchronize(false);
            return Ok(synchronizedVehicles);
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
            var synchronizedVehicles = await _vehicleService.Synchronize(true);
            return Ok(synchronizedVehicles);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost]
    [Route("addOrUpdate")]
    public async Task<IActionResult> AddOrUpdate(List<VehicleDto> vehicles)
    {
        try
        {
            var synchronizedVehicles = await _vehicleService.AddOrUpdate(vehicles);
            return Ok(synchronizedVehicles);
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
            var vehicles = await _vehicleService.Get();
            return Ok(vehicles);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
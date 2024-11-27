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
    [HttpPost]
    [Route("parseCsv")]
    public async Task<IActionResult> AddOrUpdate()
    {
        try
        {
            var fileName = Path.Combine(Directory.GetCurrentDirectory(), "Tractors.csv");
            var tractors = ParseCsv(fileName);
            await _vehicleRepository.AddOrUpdate(tractors);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    static List<VehicleDto> ParseCsv(string filePath)
    {
        var tractorDataList = new List<VehicleDto>();

        using (var reader = new StreamReader(filePath))
        {
            string line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                var columns = line.Split(';');

                var tractor = new VehicleDto()
                {
                    PlateNumber = columns[2],
                    InternalVehicleNumber = int.Parse(columns[3]),
                    CurrentCounter = int.Parse(columns[11]),
                };

                tractorDataList.Add(tractor);
            }
        }

        return tractorDataList;
    }
}
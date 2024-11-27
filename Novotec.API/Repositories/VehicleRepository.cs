using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using NovotecDB;
using NovotecDB.Models;

namespace Novotec.API.Repositories;

public class VehicleRepository : IVehicleRepository
{
    private readonly NovotecContext _context;

    public VehicleRepository(NovotecContext context)
    {
        _context = context;
    }

    public async Task AddOrUpdate(List<VehicleDto> vehicles)
    {
        var vehicleIdentifiers = vehicles.Select(x => x.InternalVehicleNumber);
        var existingVehicles = await _context.Vehicles.Where(x => vehicleIdentifiers.Contains(x.Veintno)).ToListAsync();
        var vehiclesToAdd = new List<Vehicle>();
        var vehiclesToUpdate = new List<Vehicle>();
        foreach (var vehicleDto in vehicles)
        {
            var existingVehicle = existingVehicles.FirstOrDefault(x => x.Veintno == vehicleDto.InternalVehicleNumber);
            if (existingVehicle == null)
            {
                var vehicle = new Vehicle()
                {
                    Veintno = vehicleDto.InternalVehicleNumber,
                    Vehours = vehicleDto.CurrentCounter,
                    Veplate = vehicleDto.PlateNumber
                };
                vehiclesToAdd.Add(vehicle);
            }
            else
            {
                existingVehicle.Veintno = vehicleDto.InternalVehicleNumber;
                existingVehicle.Vehours = vehicleDto.CurrentCounter;
                existingVehicle.Veplate = vehicleDto.PlateNumber;
                // existingVehicle.Vecat = vehicle.Vecat;
                // existingVehicle.Vecc = vehicle.Vecc;
                // existingVehicle.Vedate = vehicle.Vedate;
                // existingVehicle.Vekmoffset = vehicle.Vekmoffset;
                // existingVehicle.Vekmstart = vehicle.Vekmstart;
                // existingVehicle.Vemiles = vehicle.Vemiles;
                // existingVehicle.Vehhoffset = vehicle.Vehhoffset;
                // existingVehicle.Vehhstart = vehicle.Vehhstart;
                // existingVehicle.Veho = vehicle.Veho;
                // existingVehicle.Vewho = vehicle.Vewho;
                // existingVehicle.Vestoc = vehicle.Vestoc;
                // existingVehicle.Veplate2 = vehicle.Veplate2;
                // existingVehicle.Vestart = vehicle.Vestart;
                // existingVehicle.Veend = vehicle.Veend;
                // existingVehicle.Vestate = vehicle.Vestate;
                // existingVehicle.Veoffdate = vehicle.Veoffdate;
                // existingVehicle.Vememo = vehicle.Vememo;
                
                vehiclesToUpdate.Add(existingVehicle);
            }
        }

        if (vehiclesToAdd.Any())
        {
            var sql = "INSERT INTO `dbo.VEHICLE` (Veintno, Vehours, Veplate) VALUES (@Veintno, @Vehours, @Veplate)";

            foreach (var vehicleDto in vehiclesToAdd)
            {
                await _context.Database.ExecuteSqlRawAsync(sql, new[]
                {
                    new MySqlParameter("@Veintno", vehicleDto.Veintno),
                    new MySqlParameter("@Vehours", vehicleDto.Vehours),
                    new MySqlParameter("@Veplate", vehicleDto.Veplate ?? (object)DBNull.Value)
                });
            }
        }
        if (vehiclesToUpdate.Any())
        {
            var sqlUpdate = "UPDATE `dbo.VEHICLE` SET Vehours = @Vehours, Veplate = @Veplate WHERE Veintno = @Veintno";

            foreach (var vehicle in vehiclesToUpdate)
            {
                await _context.Database.ExecuteSqlRawAsync(sqlUpdate, new[]
                {
                    new MySqlParameter("@Veintno", vehicle.Veintno),
                    new MySqlParameter("@Vehours", vehicle.Vehours),
                    new MySqlParameter("@Veplate", vehicle.Veplate ?? (object)DBNull.Value)
                });
            }
        }

        await _context.SaveChangesAsync();
    }
}
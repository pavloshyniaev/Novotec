using Novotec.API.Dto;
using NovotecDB.Models;

namespace Novotec.API.Interfaces;

public interface IVehicleRepository
{
    Task SynchronizeVehicles(List<VehicleDto> vehicles);
    Task AddOrUpdate(List<VehicleDto> vehicles);
    Task<List<VehicleDto>> GetVehicles();
}
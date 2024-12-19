using Novotec.API.Dto;
using NovotecDB.Models;

namespace Novotec.API.Interfaces;

public interface IVehicleRepository
{
    Task<SynchronizedVehiclesDto> SynchronizeVehicles(List<VehicleDto> vehicles, bool onlyUpdate);
    Task<(List<VehicleDto>, List<VehicleDto>)> AddOrUpdate(List<VehicleDto> vehicles, bool externalCall = false);
    Task<List<VehicleDto>> GetVehicles(List<long>? vehicleIds = null);
}
using Novotec.API.Dto;

namespace Novotec.API.Interfaces;

public interface IVehicleService
{
    Task Synchronize();
    Task AddOrUpdate(List<VehicleDto> vehicles);
    Task<List<VehicleDto>> Get();
}
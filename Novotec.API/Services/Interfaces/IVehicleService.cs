using Novotec.API.Dto;

namespace Novotec.API.Interfaces;

public interface IVehicleService
{
    Task<SynchronizedVehiclesDto> Synchronize(bool onlyUpdate);
    Task<SynchronizedVehiclesDto> AddOrUpdate(List<VehicleDto> vehicles);
    Task<List<VehicleDto>> Get();
}
using Novotec.API.Dto;
using Novotec.API.Interfaces;

namespace Novotec.API.Services;

public class VehicleService : IVehicleService
{
    private readonly IVehicleRepository _vehicleRepository;
    private readonly IApiService _apiService;

    public VehicleService(IVehicleRepository vehicleRepository, IApiService apiService)
    {
        _vehicleRepository = vehicleRepository;
        _apiService = apiService;
    }

    public async Task<SynchronizedVehiclesDto> Synchronize()
    {
        var vehicles = await _apiService.FetchData<List<VehicleDto>>("/tank-station/vehicles");
        if (vehicles == null)
        {
            throw new ArgumentNullException("Vehicles not found");
        }
        return await _vehicleRepository.SynchronizeVehicles(vehicles);
    }

    public async Task<SynchronizedVehiclesDto> AddOrUpdate(List<VehicleDto> vehicles)
    {
        var synchronizedVehicles = await _vehicleRepository.AddOrUpdate(vehicles);
        return new SynchronizedVehiclesDto(synchronizedVehicles.Item1, synchronizedVehicles.Item2, new List<VehicleDto>());
    }

    public async Task<List<VehicleDto>> Get()
    {
        return await _vehicleRepository.GetVehicles();
    }
}
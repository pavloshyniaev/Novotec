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

    public async Task Synchronize()
    {
        var vehicles = await _apiService.FetchData<VehicleDto>("localhost/api/tankStation/vehicles");
        await _vehicleRepository.SynchronizeVehicles(vehicles);
    }

    public Task AddOrUpdate(List<VehicleDto> vehicles)
    {
        throw new NotImplementedException();
    }

    public async Task<List<VehicleDto>> Get()
    {
        return await _vehicleRepository.GetVehicles();
    }
}
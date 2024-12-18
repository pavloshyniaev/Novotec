using Novotec.API.Dto;
using Novotec.API.Interfaces;

namespace Novotec.API.Services;

public class VehicleService : IVehicleService
{
    private readonly IVehicleRepository _vehicleRepository;
    private readonly IApiService _apiService;
    private readonly string _baseUrl = "https://localhost:63504/";

    public VehicleService(IVehicleRepository vehicleRepository, IApiService apiService)
    {
        _vehicleRepository = vehicleRepository;
        _apiService = apiService;
    }

    public async Task Synchronize()
    {
        var vehicles = await _apiService.FetchData<VehicleDto>(_baseUrl + "tank-station/vehicles");
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
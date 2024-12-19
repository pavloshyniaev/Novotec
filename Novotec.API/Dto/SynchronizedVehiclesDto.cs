namespace Novotec.API.Dto;

public class SynchronizedVehiclesDto
{
    public List<VehicleDto> AddedVehicles {get; set;}
    public List<VehicleDto> UpdatedVehicles {get; set;}
    public List<VehicleDto> DeletedVehicles {get; set;}

    public SynchronizedVehiclesDto(List<VehicleDto> added, List<VehicleDto> updated, List<VehicleDto> deleted)
    {
        AddedVehicles = added;
        UpdatedVehicles = updated;
        DeletedVehicles = deleted;
    }
}
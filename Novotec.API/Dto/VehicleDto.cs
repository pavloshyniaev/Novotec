using NovotecDB.Models;

namespace Novotec.API.Dto;

public class VehicleDto
{
    // public string VehicleId => $"{VehicleCategory.ToString()[0]}{Id}";
    public string Id { get; set; }
    public VehicleCategory VehicleCategory { get; set; }
    public int VehicleTypeId { get; set; } // FahrZeugArt (LKW, PKW)
    public int VehicleFuelId { get; set; }
    public string? Fabricant { get; set; } // Manufacturer (MAN, Benz)
    public string PlateNr { get; set; }
    public string RegistrationNumber { get; set; }
    public string VehicleIdNumber { get; set; }
    public DateTime? InCompanySince { get; set; }
    public int? InitialKm { get; set; }
    public int? CurrentKm { get; set; }
    public decimal? InitialCounter { get; set; }
    public decimal? CurrentCounter { get; set; }
    public string ChipCode { get; set; }
    // we need vehicle chip as well to update chip entity 
    public VehicleCounterType VehicleCounterType => InitialKm == null ? VehicleCounterType.Hours : VehicleCounterType.Km;

    public VehicleDto()
    {
        
    }

    public VehicleDto(Vehicle vehicle)
    {
        Id = vehicle.Veident.ToString();
        VehicleCategory = (VehicleCategory)vehicle.Vecat;
        PlateNr = vehicle.Veplate;
        RegistrationNumber = vehicle.Veintno;
        VehicleIdNumber = vehicle.Vevehno;
        InCompanySince = vehicle.Vestart;
        InitialKm = vehicle.Vemiles;
        CurrentKm = vehicle.Vekmstart;
        InitialCounter = vehicle.Vehours;
        CurrentCounter = vehicle.Vehhstart;
    }
}
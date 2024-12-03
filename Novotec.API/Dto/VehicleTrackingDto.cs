public class VehicleTracking{
    public DateTime Timestamp { get; set; }
    public int? PersonId { get; set; }

    public decimal? Counter { get; set; }
    public decimal? KmCount { get; set; }
    public decimal? FuelAdded { get; set; }
        
    public decimal? Cost { get; set; }

    public string Notes { get; set; }
    public UsageType UsageType { get; set; }
}
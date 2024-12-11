namespace NovotecDB.AgrarwareConnectorModels;

public class VehicleConnector : IConnector
{
    public int Id { get; set; }
    public string AgrarwareId { get; set; }
    public long NovotecId { get; set; }
}
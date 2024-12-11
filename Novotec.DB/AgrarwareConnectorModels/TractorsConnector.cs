namespace NovotecDB.AgrarwareConnectorModels;

public class TractorConnector : IConnector
{
    public int Id { get; set; }
    public string AgrarwareId { get; set; }
    public long NovotecId { get; set; }
}
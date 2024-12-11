namespace NovotecDB.AgrarwareConnectorModels;

public interface IConnector
{
    string AgrarwareId { get; set; }
    long NovotecId { get; set; }
}
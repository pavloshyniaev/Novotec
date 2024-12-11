using Microsoft.EntityFrameworkCore;
using NovotecDB.AgrarwareConnectorModels;

namespace NovotecDB;

public class AgrarwareConnectorContext : DbContext
{
    public DbSet<EmployeeConnector> Employees { get; set; }
    public DbSet<TractorConnector> Tractors { get; set; }
    public DbSet<VehicleConnector> Vehicles { get; set; }
    public DbSet<GoodsTransportConnector> GoodsTransports { get; set; }
    
    public AgrarwareConnectorContext(DbContextOptions<AgrarwareConnectorContext> options)
        : base(options)
    {
    }
}
using NovotecDB.Models;

namespace Novotec.API.Interfaces;

public interface IEmployeeRepository
{
    Task AddOrUpdate(List<Employee> employees);
}
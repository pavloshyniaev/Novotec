using Microsoft.EntityFrameworkCore;
using Novotec.API.Interfaces;
using NovotecDB;
using NovotecDB.Models;

namespace Novotec.API.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly NovotecContext _context;

    public EmployeeRepository(NovotecContext context)
    {
        _context = context;
    }

    public async Task AddOrUpdate(List<Employee> employees)
    {
        var employeeIdentifiers = employees.Select(x => x.Emident);
        var existingEmployees = await _context.Employees.Where(x => employeeIdentifiers.Contains(x.Emident)).ToListAsync();
        var employeesToAdd = new List<Employee>();
        var employeesToUpdate = new List<Employee>();
        foreach (var employee in employees)
        {
            var existingEmployee = existingEmployees.FirstOrDefault(x => x.Emident == employee.Emident);
            if (existingEmployee == null)
            {
                employeesToAdd.Add(employee);
            }
            else
            {
                existingEmployee.Emadcomp = employee.Emadcomp;
                existingEmployee.Emident = employee.Emident;
                existingEmployee.Emadident = employee.Emadident;
                existingEmployee.Emcocode = employee.Emcocode;
                existingEmployee.Emcoid = employee.Emcoid;
                existingEmployee.Emcoident = employee.Emcoident;
                existingEmployee.Emdivabbr = employee.Emdivabbr;
                existingEmployee.Emdivision = employee.Emdivision;
                existingEmployee.Emdrivno = employee.Emdrivno;
                existingEmployee.Emgroup = employee.Emgroup;
                existingEmployee.Emho = employee.Emho;
                existingEmployee.Emiscust = employee.Emiscust;
                existingEmployee.Emwho = employee.Emwho;
                existingEmployee.Emtype = employee.Emtype;
                existingEmployee.Empersno = employee.Empersno;
                existingEmployee.Emmemo = employee.Emmemo;
                existingEmployee.Emstate = employee.Emstate;

                employeesToUpdate.Add(existingEmployee);
            }
        }

        if (employeesToAdd.Any())
        {
            _context.Employees.AddRange(employeesToAdd);
        }
        if (employeesToUpdate.Any())
        {
            _context.Employees.UpdateRange(employeesToUpdate);
        }

        await _context.SaveChangesAsync();
    }
}
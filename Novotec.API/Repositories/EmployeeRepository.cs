using Microsoft.EntityFrameworkCore;
using Novotec.API.Dto;
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

    public async Task AddOrUpdate(List<PersonDto> employees)
    {
        var employeeIdentifiers = employees.Select(x => (long)x.PersonId);
        var existingEmployees = await _context.Employees.Where(x => employeeIdentifiers.Contains(x.Emident)).ToListAsync();
        var employeesToDelete = await _context.Employees
            .Where(x => !employeeIdentifiers.Contains(x.Emident))
            .ToListAsync();
        
        foreach (var employee in employees)
        {
            var existingEmployee = existingEmployees.FirstOrDefault(x => x.Emident == employee.PersonId);
            var card = await _context.Cards.FirstOrDefaultAsync(x => x.Cano == employee.ChipCode); // or chipNumber
            if (existingEmployee == null)
            {
                //++ UPDATE [dbo].[CARDS] SET [CADATE]='20241202 17:17:40.567', [CAWHO]=40, [CAEMIDENT]=232 WHERE [CAIDENT]=459
                // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=459 WHERE [SVIDENT]=188
                // UPDATE [dbo].[WSTATION] SET [WSDATE]='20241202 17:20:48.067' WHERE [WSIDENT]=34
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241202 17:21:02.000' WHERE [CUIDENT]=62245
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241202 17:19:35.000' WHERE [CUIDENT]=62246
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241202 17:21:05.000' WHERE [CUIDENT]=62247
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241202 17:20:43.000' WHERE [CUIDENT]=62248
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241202 16:59:07.000' WHERE [CUIDENT]=62252
                // INSERT INTO [dbo].[CURRSTATUS] ([CUIDENT], [CUDATE], [CUTYPE], [CUPINFO], [CUSTATION], [CUPROGNO], [CUMESSID], [CUMESSAGE], [CUMEMO], [CUCRITICAL]) 
                // VALUES (62254, '20241202 17:19:47.000', 5, ' ', 'AGRARWARE', 9000001, 0, ' ', ' ', 0)
                // INSERT INTO [dbo].[LOGIN] ([LOIDENT], [LODATE], [LOWHO], [LOADMIN], [LOTYPE], [LOPROG])
                // VALUES (80141, '20241202 15:23:22.750', 40, '2', '0', 'SVMAIN.EXE               ')
                //++ INSERT INTO [dbo].[ADDRESS] ([ADIDENT], [ADWHO], [ADDATE], [ADTYPE], [ADLOC], [ADZIP], [ADCTRY], [ADSTR], [ADHP], [ADPB], [ADFNAME1], [ADLNAME1], [ADTITLE1], [ADGEN1], [ADTEL1], [ADTEL2], [ADFAX1], [ADEMAIL1], [ADFNAME2], [ADLNAME2], [ADTITLE2], [ADGEN2], [ADTEL3], [ADTEL4], [ADFAX2], [ADEMAIL2], [ADBANK1], [ADROUTNO1], [ADIBAN1], [ADACC1], [ADIBC1], [ADBANK2], [ADROUTNO2], [ADIBAN2], [ADACC2], [ADIBC2], [ADBANK3], [ADROUTNO3], [ADIBAN3], [ADACC3], [ADIBC3], [ADBANK4], [ADROUTNO4], [ADIBAN4], [ADACC4], [ADIBC4], [ADBANK5], [ADROUTNO5], [ADIBAN5], [ADACC5], [ADIBC5], [ADXXIDENT], [ADVATID], [ADTAXID]) 
                // VALUES (468, 40, '20241202 17:17:00.000', 1, 'ort', 'plz', 'Deutschland', 'street', '', 'zip', 'Vorname', 'Name', '123', 0, '00112privattelefon', '050privatmobil', '050privatfax', 'privatGmail.com', '', '', '', 0, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 232, '', '')
                //-- INSERT INTO [dbo].[ADDRESS] ([ADIDENT], [ADWHO], [ADDATE], [ADTYPE], [ADLOC], [ADZIP], [ADCTRY], [ADSTR], [ADHP], [ADPB], [ADFNAME1], [ADLNAME1], [ADTITLE1], [ADGEN1], [ADTEL1], [ADTEL2], [ADFAX1], [ADEMAIL1], [ADFNAME2], [ADLNAME2], [ADTITLE2], [ADGEN2], [ADTEL3], [ADTEL4], [ADFAX2], [ADEMAIL2], [ADBANK1], [ADROUTNO1], [ADIBAN1], [ADACC1], [ADIBC1], [ADBANK2], [ADROUTNO2], [ADIBAN2], [ADACC2], [ADIBC2], [ADBANK3], [ADROUTNO3], [ADIBAN3], [ADACC3], [ADIBC3], [ADBANK4], [ADROUTNO4], [ADIBAN4], [ADACC4], [ADIBC4], [ADBANK5], [ADROUTNO5], [ADIBAN5], [ADACC5], [ADIBC5], [ADXXIDENT], [ADVATID], [ADTAXID]) 
                // VALUES (469, 40, '20241202 17:17:00.000', 7, '', '', '', '', '', '', '', '', '', 0, '1234567890com', '12345com', '123com', 'gmail.com', '', '', '', 0, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 232, '', '')
                // INSERT INTO [dbo].[RESPONSE] ([RSIDENT], [RSDATE], [RSORIDENT], [RSAUIDENT], [RSSTATE], [RSDATA], [RSRQNO]) 
                // VALUES (204841, '20241202 17:17:40.000', 185916, 1, 0, '232', 5000)
                // INSERT INTO [dbo].[RESPONSE] ([RSIDENT], [RSDATE], [RSORIDENT], [RSAUIDENT], [RSSTATE], [RSDATA], [RSRQNO])
                // VALUES (204842, '20241202 17:17:40.000', 185917, 1, 0, '232', 5023)
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (842, '20241202 17:17:40.000', 40, 459, 0, 0, 0, 232, 0)
                // INSERT INTO [dbo].[ORDERS] ([ORIDENT], [ORDATE], [ORAUIDENT], [ORSTATE], [ORRQNO], [ORDATA], [ORERROR], [ORPROGNO], [ORCNT], [ORWHO], [ORSTART]) 
                // VALUES (185916, '20241202 17:17:40.900', 1, 0, 5000, '232', 0, 1, 0, 40, NULL)
                // INSERT INTO [dbo].[ORDERS] ([ORIDENT], [ORDATE], [ORAUIDENT], [ORSTATE], [ORRQNO], [ORDATA], [ORERROR], [ORPROGNO], [ORCNT], [ORWHO], [ORSTART]) 
                // VALUES (185917, '20241202 17:17:40.900', 1, 0, 5023, '232', 0, 1, 0, 40, NULL)
                // INSERT INTO [dbo].[QUEUES] ([QEIDENT], [QEDATE], [QEORIDENT], [QEAUIDENT], [QESTATE], [QERQNO], [QEDATA], [QECNT], [QEBLOCKNO]) 
                // VALUES (203739, '20241202 17:17:40.947', 185916, 1, 1, 5000, 'V1001880000110080**********************N0000000007;98304', 0, -1)
                // INSERT INTO [dbo].[QUEUES] ([QEIDENT], [QEDATE], [QEORIDENT], [QEAUIDENT], [QESTATE], [QERQNO], [QEDATA], [QECNT], [QEBLOCKNO]) 
                // VALUES (203740, '20241202 17:17:40.947', 185916, 1, 1, 5000, 'Q1930,1,500', 0, -1)
                // INSERT INTO [dbo].[SVACCDRIV] ([SAIDENT], [SAEMIDENT], [SAAUIDENT], [SAACCOUNT], [SADRVNO], [SAPIN]) 
                // VALUES (2, 232, 1, 1, '1123355', 0)
                //++ INSERT INTO [dbo].[EMPLOYEE] ([EMIDENT], [EMDATE], [EMWHO], [EMPERSNO], [EMDRIVNO], [EMSTART], [EMEND], [EMTYPE], [EMLEIDENT], [EMCOIDENT], [EMADIDENT], [EMMEMO], [EMSTATE], [EMADCOMP], [EMISCUST], [EMCOID], [EMCOCODE], [EMHO], [EMDIVISION], [EMDIVABBR], [EMGROUP]) 
                // VALUES (232, '20241202 17:17:40.550', 40, '1245512', '1123355', '20241202 00:00:00.000', NULL, 0, 0, 0, 468, '', '', 469, 0, NULL, '', '', '', '', '')

                var address = new Address()
                {
                    Adfname1 = employee.FirstName,
                    Adlname1 = employee.LastName,
                };
                var newEmployee = new Employee()
                {
                    Empersno = employee.PersonalNumber,
                    Emstart = employee.ContractFrom,
                    Emend = employee.ContractTo,
                    Emadident = address.Adident
                };
                if (card != null)
                {
                    card.Caemident = newEmployee.Emident;
                    card.Cano = employee.ChipCode;
                }

                _context.Addresses.Add(address);
                _context.Employees.Add(newEmployee);
            }
            else
            {
                var existingAddress = await _context.Addresses.FirstOrDefaultAsync(x => x.Adident == existingEmployee.Emadident);
                if (existingAddress != null)
                {
                    existingAddress.Adfname1 = employee.FirstName;
                    existingAddress.Adlname1 = employee.LastName;
                }
                if (card != null)
                {
                    card.Caemident = existingEmployee.Emident;
                    card.Cano = employee.ChipCode;
                }
                existingEmployee.Empersno = employee.PersonalNumber;
                existingEmployee.Emstart = employee.ContractFrom;
                existingEmployee.Emend = employee.ContractTo;

                _context.Update(existingEmployee);
            }
        }
        
        if (employeesToDelete.Any())
        {
            _context.Employees.RemoveRange(employeesToDelete);   
        }

        await _context.SaveChangesAsync();
    }
    
    public async Task<List<PersonDto>> GetEmployees()
    {
        var persons = new List<PersonDto>();
        var employees = await _context.Employees.ToListAsync();
        var employeeIds = employees.Select(x => x.Emident);
        var addressIds = employees.Select(x => x.Emadident);
        var cards = await _context.Cards.Where(x => employeeIds.Contains(x.Caemident)).ToListAsync();
        var addresses = await _context.Addresses.Where(x => addressIds.Contains(x.Adident)).ToListAsync();
        foreach (var employee in employees)
        {
            var card = cards.FirstOrDefault(x => x.Caemident == employee.Emident);
            var address = addresses.FirstOrDefault(x => x.Adident == employee.Emadident);
            persons.Add(new PersonDto(employee, address, card));
        }
        return persons;
    }
}
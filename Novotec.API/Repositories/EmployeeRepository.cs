using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using NovotecDB;
using NovotecDB.AgrarwareConnectorModels;
using NovotecDB.Models;

namespace Novotec.API.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly NovotecContext _context;
    private readonly AgrarwareConnectorContext _connectorContext;

    public EmployeeRepository(NovotecContext context, AgrarwareConnectorContext connectorContext)
    {
        _context = context;
        _connectorContext = connectorContext;
    }
    
    public async Task SynchronizeEmployees(List<PersonDto> employees)
    {
        await SynchronizeIds(employees);
        var novotecEmployeeIds = await GetNovotecIds(employees);
        var existingEmployees = await _context.Employees.Where(x => novotecEmployeeIds.Select(c => c.NovotecId).Contains(x.Emident)).ToListAsync();
        var employeesToDelete = await _context.Employees
            .Where(x => !novotecEmployeeIds.Select(c => c.NovotecId).Contains(x.Emident))
            .ToListAsync();
        
        await DeleteEmployees(employeesToDelete, false);

        foreach (var employee in employees)
        {
            var novotecId = novotecEmployeeIds.FirstOrDefault(x => x.AgrarwareId == employee.PersonId)?.NovotecId;
            var existingEmployee = existingEmployees.FirstOrDefault(x => x.Emident == novotecId);
            if (existingEmployee == null)
            {
                    //++ UPDATE [dbo].[CARDS] SET [CADATE]='20241202 17:17:40.567', [CAWHO]=40, [CAEMIDENT]=232 WHERE [CAIDENT]=459
                // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=459 WHERE [SVIDENT]=188 // probably takes the first unused entry (where cardId is not set in SVACCOUNT and assigns cardId to this entity
                // UPDATE [dbo].[WSTATION] SET [WSDATE]='20241202 17:20:48.067' WHERE [WSIDENT]=34 // ignore for now
                    //++ INSERT INTO [dbo].[ADDRESS] ([ADIDENT], [ADWHO], [ADDATE], [ADTYPE], [ADLOC], [ADZIP], [ADCTRY], [ADSTR], [ADHP], [ADPB], [ADFNAME1], [ADLNAME1], [ADTITLE1], [ADGEN1], [ADTEL1], [ADTEL2], [ADFAX1], [ADEMAIL1], [ADFNAME2], [ADLNAME2], [ADTITLE2], [ADGEN2], [ADTEL3], [ADTEL4], [ADFAX2], [ADEMAIL2], [ADBANK1], [ADROUTNO1], [ADIBAN1], [ADACC1], [ADIBC1], [ADBANK2], [ADROUTNO2], [ADIBAN2], [ADACC2], [ADIBC2], [ADBANK3], [ADROUTNO3], [ADIBAN3], [ADACC3], [ADIBC3], [ADBANK4], [ADROUTNO4], [ADIBAN4], [ADACC4], [ADIBC4], [ADBANK5], [ADROUTNO5], [ADIBAN5], [ADACC5], [ADIBC5], [ADXXIDENT], [ADVATID], [ADTAXID]) 
                    // VALUES (468, 40, '20241202 17:17:00.000', 1, 'ort', 'plz', 'Deutschland', 'street', '', 'zip', 'Vorname', 'Name', '123', 0, '00112privattelefon', '050privatmobil', '050privatfax', 'privatGmail.com', '', '', '', 0, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 232, '', '')
            //-- INSERT INTO [dbo].[ADDRESS] ([ADIDENT], [ADWHO], [ADDATE], [ADTYPE], [ADLOC], [ADZIP], [ADCTRY], [ADSTR], [ADHP], [ADPB], [ADFNAME1], [ADLNAME1], [ADTITLE1], [ADGEN1], [ADTEL1], [ADTEL2], [ADFAX1], [ADEMAIL1], [ADFNAME2], [ADLNAME2], [ADTITLE2], [ADGEN2], [ADTEL3], [ADTEL4], [ADFAX2], [ADEMAIL2], [ADBANK1], [ADROUTNO1], [ADIBAN1], [ADACC1], [ADIBC1], [ADBANK2], [ADROUTNO2], [ADIBAN2], [ADACC2], [ADIBC2], [ADBANK3], [ADROUTNO3], [ADIBAN3], [ADACC3], [ADIBC3], [ADBANK4], [ADROUTNO4], [ADIBAN4], [ADACC4], [ADIBC4], [ADBANK5], [ADROUTNO5], [ADIBAN5], [ADACC5], [ADIBC5], [ADXXIDENT], [ADVATID], [ADTAXID]) 
            // VALUES (469, 40, '20241202 17:17:00.000', 7, '', '', '', '', '', '', '', '', '', 0, '1234567890com', '12345com', '123com', 'gmail.com', '', '', '', 0, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 232, '', '')
                    // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                    // VALUES (842, '20241202 17:17:40.000', 40, 459, 0, 0, 0, 232, 0)
                    // INSERT INTO [dbo].[SVACCDRIV] ([SAIDENT], [SAEMIDENT], [SAAUIDENT], [SAACCOUNT], [SADRVNO], [SAPIN]) 
                    // VALUES (2, 232, 1, 1, '1123355', 0)
                    //++ INSERT INTO [dbo].[EMPLOYEE] ([EMIDENT], [EMDATE], [EMWHO], [EMPERSNO], [EMDRIVNO], [EMSTART], [EMEND], [EMTYPE], [EMLEIDENT], [EMCOIDENT], [EMADIDENT], [EMMEMO], [EMSTATE], [EMADCOMP], [EMISCUST], [EMCOID], [EMCOCODE], [EMHO], [EMDIVISION], [EMDIVABBR], [EMGROUP]) 
                    // VALUES (232, '20241202 17:17:40.550', 40, '1245512', '1123355', '20241202 00:00:00.000', NULL, 0, 0, 0, 468, '', '', 469, 0, NULL, '', '', '', '', '')

                var address = new Address()
                {
                    Adfname1 = employee.FirstName,
                    Adlname1 = employee.LastName,
                    Adctry = employee.Country,
                    Adstr = employee.StreetName,
                    Adzip = employee.ZipCode,
                    Adloc = employee.City
                };

                _context.Addresses.Add(address);
                await _context.SaveChangesAsync();
                
                var newEmployee = new Employee()
                {
                    Empersno = employee.PersonalNumber,
                    Emstart = employee.ContractFrom,
                    Emend = employee.ContractTo,
                    Emadident = address.Adident,
                    Emdate = DateTime.Now,
                };
                
                _context.Employees.Add(newEmployee);
                await _context.SaveChangesAsync();
                
                if (!string.IsNullOrEmpty(newEmployee.Emdrivno))
                {
                    var svAccDriv = new Svaccdriv()
                    {
                        Saemident = newEmployee.Emident,
                        Saauident = 1,
                        Sadrvno = newEmployee.Emdrivno
                    };
                    _context.Svaccdrivs.Add(svAccDriv);
                }

                await UnassignExistingCard(newEmployee.Emident, employee.ChipCode);
                await AssignNewCard(newEmployee.Emident, employee.ChipCode);
                
                var connectedEmployee = new EmployeeConnector()
                {
                    AgrarwareId = employee.PersonId,
                    NovotecId = newEmployee.Emident
                };
                _connectorContext.Employees.Add(connectedEmployee);
                await _connectorContext.SaveChangesAsync();
            }
            else
            {
                // UPDATE [dbo].[EMPLOYEE] SET [EMDATE]='20241204 13:15:51.547', [EMEND]='20241204 00:00:00.000', [EMSTATE]='gelöscht' WHERE [EMIDENT]=127
                // UPDATE [dbo].[CARDS] SET [CADATE]='20241204 13:15:51.570', [CAEMIDENT]=0 WHERE [CAIDENT]=306
                // UPDATE [dbo].[CARDS] SET [CADATE]='20241120 14:31:43.000' WHERE [CAIDENT]=445
                // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=0 WHERE [SVIDENT]=294
                // UPDATE [dbo].[WSTATION] SET [WSDATE]='20241204 13:15:40.787' WHERE [WSIDENT]=34
                // UPDATE [dbo].[ADDRESS] SET [ADDATE]='20241204 13:15:00.000', [ADPB]='qqq', [ADFNAME1]='Florine' WHERE [ADIDENT]=258
                // UPDATE [dbo].[ADDRESS] SET [ADDATE]='20241204 13:15:00.000', [ADFNAME1]='Florine' WHERE [ADIDENT]=259
                // SET IDENTITY_INSERT [dbo].[CAHISTORY] ON
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (842, '20241204 13:15:51.000', 41, 445, 0, 0, 0, 127, 0)
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (843, '20241204 13:15:51.000', 41, 306, 0, 0, 0, 0, 0)
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (844, '20241204 13:15:51.000', 41, 306, 0, 0, 0, 0, 0)
                var existingAddress = await _context.Addresses.FirstOrDefaultAsync(x => x.Adident == existingEmployee.Emadident);
                if (existingAddress != null)
                {
                    existingAddress.Adfname1 = employee.FirstName;
                    existingAddress.Adlname1 = employee.LastName;
                    existingAddress.Adctry = employee.Country;
                    existingAddress.Adstr = employee.StreetName;
                    existingAddress.Adzip = employee.ZipCode;
                    existingAddress.Adloc = employee.City;
                    _context.Addresses.Update(existingAddress);
                }
                
                //probably check other cards, and see if there is any other cards bounded to this user, if so, delete employee id from them, as probably, one employee shouldn't have more than one card
                await UnassignExistingCard(existingEmployee.Emident, employee.ChipCode);
                await AssignNewCard(existingEmployee.Emident, employee.ChipCode);
                
                existingEmployee.Empersno = employee.PersonalNumber;
                existingEmployee.Emstart = employee.ContractFrom;
                existingEmployee.Emend = employee.ContractTo;
                existingEmployee.Emdate = DateTime.Now;

                _context.Employees.Update(existingEmployee);
            }
        }
        
        await _context.SaveChangesAsync();
    }
    
    public async Task<List<PersonDto>> GetEmployees()
    {
        var persons = new List<PersonDto>();
        var currentDateTime = DateTime.Now;
        var employees = await _context.Employees.Where(x => x.Emend == null || x.Emend.Value > currentDateTime).ToListAsync();
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

    public async Task DeleteEmployees(List<Employee> employees, bool forceDelete)
    {
        // UPDATE [dbo].[EMPLOYEE] SET [EMDATE]='20241204 12:24:46.000', [EMWHO]=40 WHERE [EMIDENT]=146
        // UPDATE [dbo].[CARDS] SET [CADATE]='20241204 12:24:46.987', [CAEMIDENT]=0 WHERE [CAIDENT]=358
        // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=0 WHERE [SVIDENT]=346
        // UPDATE [dbo].[WSTATION] SET [WSDATE]='20241204 12:34:52.887' WHERE [WSIDENT]=34
        // UPDATE [dbo].[ADDRESS] SET [ADWHO]=40, [ADDATE]='20241204 12:28:00.000' WHERE [ADIDENT]=296
        // UPDATE [dbo].[ADDRESS] SET [ADWHO]=40, [ADDATE]='20241204 12:28:00.000', [ADXXIDENT]=146 WHERE [ADIDENT]=297
        // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
        // VALUES (842, '20241204 12:24:46.000', 41, 358, 0, 0, 0, 0, 0)

        foreach (var employee in employees)
        {
            await UnassignExistingCard(employee.Emident, "");
            if (!forceDelete)
            {
                employee.Emend = DateTime.Now;
                _context.Employees.Update(employee);
            }
        }

        if (forceDelete)
        {
            _context.Employees.RemoveRange(employees);
        }
        await _context.SaveChangesAsync();
    }
    public async Task DeleteDuplicates()
    {
        var duplicateEmployees = await _context.Employees
            .GroupBy(x => x.Empersno)
            .Where(g => g.Count() > 1)
            .SelectMany(g => g)
            .ToListAsync();
        
        foreach (var employee in duplicateEmployees)
        {
            await UnassignExistingCard(employee.Emident, "");
        }
        
        _context.Employees.RemoveRange(duplicateEmployees);
        await _context.SaveChangesAsync();
    }
    private async Task SynchronizeIds(List<PersonDto> employees)
    {
        var personalNumbers = employees.Select(e => e.PersonalNumber);
        var existingEmployees = await _context.Employees.Where(x => personalNumbers.Contains(x.Empersno)).ToListAsync();
        foreach (var existingEmployee in existingEmployees)
        {
            var employee = employees.FirstOrDefault(x => x.PersonalNumber == existingEmployee.Empersno);
            if (employee != null)
            {
                var existingConnection = await _connectorContext.Employees.FirstOrDefaultAsync(x => x.AgrarwareId == employee.PersonId);
                if (existingConnection == null)
                {
                    var connectedEmployee = new EmployeeConnector()
                    {
                        AgrarwareId = employee.PersonId,
                        NovotecId = existingEmployee.Emident
                    };
                    _connectorContext.Employees.Add(connectedEmployee);
                }
            }
        }
        await _connectorContext.SaveChangesAsync();
    }

    private async Task<List<EmployeeConnector>> GetNovotecIds(List<PersonDto> employees)
    {
        var employeeIdentifiers = employees.Select(x => x.PersonId);
        var novotecEmployeeIds = await _connectorContext.Employees.Where(x => employeeIdentifiers.Contains(x.AgrarwareId)).ToListAsync();
        
        return novotecEmployeeIds;
    }
    private async Task UnassignExistingCard(long employeeId, string newCardNumber)
    {
        var existingCards = await _context.Cards.Where(x => x.Caemident == employeeId).ToListAsync();
        foreach(var existingCard in existingCards)
        {
            // check here if this card is the one we want to assign
            if (existingCard.Cano != newCardNumber)
            {
                existingCard.Caemident = 0;

                await UpdateCardHistory(0, existingCard.Caident);

                var svAccount = await _context.Svaccounts.FirstOrDefaultAsync(x => x.Svcaident == existingCard.Caident);
                if (svAccount != null)
                {
                    svAccount.Svcaident = 0;
                    _context.Svaccounts.Update(svAccount);
                }

                _context.Cards.Update(existingCard);
            }
        }

        await _context.SaveChangesAsync();
    }

    private async Task AssignNewCard(long employeeId, string cardNumber)
    {
        var newCard = await _context.Cards.FirstOrDefaultAsync(x => x.Cano == cardNumber);
        if (newCard != null)
        {
            // we probably need a check if this card was assigned to somebody else
            if (newCard.Caemident != employeeId)
            {
                newCard.Caemident = employeeId;
                
                _context.Cards.Update(newCard);
                
                await UpdateCardHistory(employeeId, newCard.Caident);
                await SetCardActive(newCard.Caident);
            }
        }
        else
        {
            newCard = await _context.Cards.FirstOrDefaultAsync(x => x.Caemident == 0 && x.Catype == 1);
            if (newCard == null)
            {
                throw new ArgumentException("No unassigned cards left");
            }

            newCard.Cano = cardNumber;
            newCard.Cano2 = cardNumber;
            newCard.Caemident = employeeId;
            
            _context.Cards.Update(newCard);

            await UpdateCardHistory(employeeId, newCard.Caident);
            await SetCardActive(newCard.Caident);
        }
        await _context.SaveChangesAsync();
    }

    private async Task UpdateCardHistory(long employeeId, long cardId)
    {
        var cardHistory = new Cahistory()
        {
            Chdate = DateTime.Now,
            Chemident = employeeId,
            Chcaident = cardId
        };
        await _context.Cahistories.AddAsync(cardHistory);
    }

    private async Task SetCardActive(long cardId)
    {
        var svAccount = await _context.Svaccounts.FirstOrDefaultAsync(x => x.Svcaident == 0);
        if (svAccount != null)
        {
            svAccount.Svcaident = cardId;
            _context.Svaccounts.Update(svAccount);
        }
    }
}
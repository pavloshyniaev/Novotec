using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using NovotecDB;
using NovotecDB.AgrarwareConnectorModels;
using NovotecDB.Models;

namespace Novotec.API.Repositories;

public class VehicleRepository : IVehicleRepository
{
    private readonly NovotecContext _context;
    private readonly AgrarwareConnectorContext _connectorContext;

    public VehicleRepository(NovotecContext context, AgrarwareConnectorContext connectorContext)
    {
        _context = context;
        _connectorContext = connectorContext;
    }
    
    public async Task<SynchronizedVehiclesDto> SynchronizeVehicles(List<VehicleDto> vehicles, bool onlyUpdate)
    {
        await SynchronizeIds(vehicles);
        var deletedVehicles = new List<VehicleDto>();
        var synchronizedVehicles = await AddOrUpdate(vehicles);
        
        if (!onlyUpdate)
        {
            var novotecVehicleIds = await GetNovotecIds(vehicles);
            var vehiclesToDelete = await _context.Vehicles
                .Where(x => !novotecVehicleIds.Select(c => c.NovotecId).Contains(x.Veident))
                .ToListAsync();

            deletedVehicles = await DeleteVehicles(vehiclesToDelete, false);
        }
        
        return new SynchronizedVehiclesDto(synchronizedVehicles.Item1, synchronizedVehicles.Item2, deletedVehicles);
    }
    
    public async Task<(List<VehicleDto>, List<VehicleDto>)> AddOrUpdate(List<VehicleDto> vehicles, bool externalCall = false)
    {
        if (externalCall)
        {
            await SynchronizeIds(vehicles);
        }
        var novotecVehicleIds = await GetNovotecIds(vehicles);
        var existingVehicles = await _context.Vehicles.Where(x => novotecVehicleIds.Select(c => c.NovotecId).Contains(x.Veident)).ToListAsync();
        var addedVehicles = vehicles.Where(a => !existingVehicles.Select(b => b.Veintno).Contains(a.RegistrationNumber)).ToList();
        var updatedVehicles = vehicles.Where(a => !addedVehicles.Select(b => b.RegistrationNumber).Contains(a.RegistrationNumber)).ToList();
        await DeleteDuplicates();

        foreach (var vehicle in vehicles)
        {
            var novotecId = novotecVehicleIds.FirstOrDefault(x => x.AgrarwareId == vehicle.Id)?.NovotecId;
            var existingVehicle = existingVehicles.FirstOrDefault(x => x.Veident == novotecId);
            if (existingVehicle == null)
            {
                    // UPDATE [dbo].[CARDS] SET [CADATE]='20221108 12:35:56.000', [CAVEIDENT]=340 WHERE [CAIDENT]=185
                // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=185 WHERE [SVIDENT]=188
                // INSERT INTO [dbo].[VTECH] ([VTIDENT], [VTDATE], [VTWHO], [VTTANK], [VTNORM], [VTTYRESIZ1], [VTTYRESIZ2], [VTTYRESIZ3], [VTTYRESIZ4], [VTTYRESIZ5], [VTTYRESIZE], [VTSTEER1], [VTSTEER2], [VTSTEER3], [VTSTEER4], [VTSTEER5], [VTLIFT1], [VTLIFT2], [VTLIFT3], [VTLIFT4], [VTLIFT5], [VTTWIN1], [VTTWIN2], [VTTWIN3], [VTTWIN4], [VTTWIN5], [VTGVW], [VTSWL], [VTRET], [VTUNDA], [VTMOTOR], [VTMPOWER], [VTCYCLAP], [VTSEATS], [VTSTAND], [VTMEMO], [VTLOADAREA], [VTHOLD], [VTLOADH], [VTLOADW], [VTLOADL], [VTPOS], [VTNEG], [VTCO2], [VTDATEMAINT], [VTTANKVOLMINP], [VTTANKVOLMAXP], [VTTANKH2KG], [VTMINTEMP], [VTMAXTEMP], [VTMAXP], [VTMINP], [VTH2TYPE]) 
                // VALUES (340, '20241203 09:09:46.487', 40, 40, 9.0, '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 'Dienstag, 3. Dezember 2024 09:09', 0, 0, 0, 0, 0, 1.0, 1.0, 0, NULL, 0, 0, 0, 0, 0, 0, 0, 0)
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (842, '20241203 09:09:46.000', 41, 185, 0, 0, 340, 0, 0)
                // INSERT INTO [dbo].[VREFATT] ([VRIDENT], [VRVCIDENT], [VRVEIDENT]) 
                // VALUES (1, 1, 0) -  VRVCIDENT is (Values 1-4 are vehicleTypeId, values 5-8 are fabricant)
                // INSERT INTO [dbo].[VREFATT] ([VRIDENT], [VRVCIDENT], [VRVEIDENT]) 
                // VALUES (2, 5, 0)
                // INSERT INTO [dbo].[STHISTORY] ([SHIDENT], [SHDATE], [SHWHO], [SHVALDATE], [SHSRIDENT], [SHCOIDENT], [SHVEIDENT]) 
                // VALUES (340, '20241203 09:09:46.000', 40, '20241203 09:09:00.000', 0, 0, 340)
                // INSERT INTO [dbo].[VEHICLE] ([VEIDENT], [VEDATE], [VEWHO], [VEINTNO], [VEVEHNO], [VEPLATE], [VEMEMO], [VEPBIDENT], [VEPGIDENT], [VESTART], [VEEND], [VELEIDENT], [VECOIDENT], [VECC], [VEEMIDENT], [VESTOC], [VESRIDENT], [VEMILES], [VEHOURS], [VETYPE], [VEKMOFFSET], [VEHHOFFSET], [VEOFFDATE], [VEKMSTART], [VEHHSTART], [VEPLATE2], [VESTATE], [VECOCODE], [VEHO], [VEDIVISION], [VEDIVABBR], [VEGROUP], [VECAT]) 
                // VALUES (340, '20241203 09:09:46.477', 40, '1-2-3-4-5', '', '12345', '', 0, 0, '20241204 00:00:00.000', NULL, 0, 0, '', 0, '', 0, 1000, 0.00, 1, 445, 0.00, '20241103 00:00:00.000', 555, 0.00, '12345', '', '', '', '', '', '', 1)

                // var vtech = new
                // {
                //     VTIDENT = 340,
                //     VTDATE = "2024-12-03 09:09:46.487",
                //     VTWHO = 40,
                //     VTTANK = 40,
                //     VTNORM = 9.0,
                //     VTMEMO = "Dienstag, 3. Dezember 2024 09:09",
                //     VTNEG = 1.0,
                //     VTCO2 = 1.0,
                // };
                await CreateVehicle(vehicle);
            }
            else
            {
                // UPDATE [dbo].[VEHICLE] SET [VEDATE]='20241206 09:36:30.317', [VEWHO]=40, [VESTART]='20241206 00:00:00.000', [VEEND]='20241231 00:00:00.000', [VEMILES]=124100, [VEHOURS]=0.00, [VEKMOFFSET]=22, [VEOFFDATE]='20241206 00:00:00.000', [VESTATE]='gelöscht' WHERE [VEIDENT]=206
                // UPDATE [dbo].[CARDS] SET [CADATE]='20241206 09:36:30.327', [CAVEIDENT]=0 WHERE [CAIDENT]=261
                // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=0 WHERE [SVIDENT]=249
                // INSERT INTO [dbo].[VTECH] ([VTIDENT], [VTDATE], [VTWHO], [VTTANK], [VTNORM], [VTTYRESIZ1], [VTTYRESIZ2], [VTTYRESIZ3], [VTTYRESIZ4], [VTTYRESIZ5], [VTTYRESIZE], [VTSTEER1], [VTSTEER2], [VTSTEER3], [VTSTEER4], [VTSTEER5], [VTLIFT1], [VTLIFT2], [VTLIFT3], [VTLIFT4], [VTLIFT5], [VTTWIN1], [VTTWIN2], [VTTWIN3], [VTTWIN4], [VTTWIN5], [VTGVW], [VTSWL], [VTRET], [VTUNDA], [VTMOTOR], [VTMPOWER], [VTCYCLAP], [VTSEATS], [VTSTAND], [VTMEMO], [VTLOADAREA], [VTHOLD], [VTLOADH], [VTLOADW], [VTLOADL], [VTPOS], [VTNEG], [VTCO2], [VTDATEMAINT], [VTTANKVOLMINP], [VTTANKVOLMAXP], [VTTANKH2KG], [VTMINTEMP], [VTMAXTEMP], [VTMAXP], [VTMINP], [VTH2TYPE]) 
                // VALUES (19, '20241206 09:33:19.350', 41, 0, 0.0, '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0.0, 0.0, 0, '19890101 00:00:00.000', 0, 0, 0, 0, 0, 0, 0, -1)
                // INSERT INTO [dbo].[VTECH] ([VTIDENT], [VTDATE], [VTWHO], [VTTANK], [VTNORM], [VTTYRESIZ1], [VTTYRESIZ2], [VTTYRESIZ3], [VTTYRESIZ4], [VTTYRESIZ5], [VTTYRESIZE], [VTSTEER1], [VTSTEER2], [VTSTEER3], [VTSTEER4], [VTSTEER5], [VTLIFT1], [VTLIFT2], [VTLIFT3], [VTLIFT4], [VTLIFT5], [VTTWIN1], [VTTWIN2], [VTTWIN3], [VTTWIN4], [VTTWIN5], [VTGVW], [VTSWL], [VTRET], [VTUNDA], [VTMOTOR], [VTMPOWER], [VTCYCLAP], [VTSEATS], [VTSTAND], [VTMEMO], [VTLOADAREA], [VTHOLD], [VTLOADH], [VTLOADW], [VTLOADL], [VTPOS], [VTNEG], [VTCO2], [VTDATEMAINT], [VTTANKVOLMINP], [VTTANKVOLMAXP], [VTTANKH2KG], [VTMINTEMP], [VTMAXTEMP], [VTMAXP], [VTMINP], [VTH2TYPE]) 
                // VALUES (206, '20241206 09:36:30.320', 40, 33, 5.0, '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 'Freitag, 6. Dezember 2024 09:36', 0, 0, 0, 0, 0, 2.0, 2.0, 2, NULL, 0, 0, 0, 0, 0, 0, 0, -1)
                // SET IDENTITY_INSERT [dbo].[CAHISTORY] ON
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (842, '20241206 09:36:30.000', 41, 261, 0, 0, 0, 0, 0)
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (843, '20241206 09:36:30.000', 41, 261, 0, 0, 0, 0, 0)
                // INSERT INTO [dbo].[VREFATT] ([VRIDENT], [VRVCIDENT], [VRVEIDENT]) 
                // VALUES (1, 1, 206)

                await UpdateVehicle(vehicle, existingVehicle);
            }
        }
        
        await _context.SaveChangesAsync();
        return (addedVehicles, updatedVehicles);
    }

    public async Task<List<VehicleDto>> GetVehicles(List<long>? vehicleIds = null)
    {
        var currentTime = DateTime.Now;
        var result = new List<VehicleDto>();
        var vehicles = await _context.Vehicles.Where(x => x.Veend == null || x.Veend > currentTime).ToListAsync();
        if (vehicleIds != null)
        {
            vehicles = vehicles.Where(x => vehicleIds.Contains(x.Veident)).ToList();
        }

        foreach (var vehicle in vehicles)
        {
            var vehicleConnector = await ConnectorExists((VehicleCategory)vehicle.Vecat, null, vehicle.Veident);
            result.Add(new VehicleDto(vehicle, vehicleConnector?.AgrarwareId));
        }

        return result;
    }
    private async Task<List<VehicleDto>> DeleteVehicles(List<Vehicle> vehicles, bool forceDelete)
    {
        var vehiclesToDelete = await GetVehicles(vehicles.Select(x => x.Veident).ToList());
        foreach (var vehicle in vehicles)
        {
            await UnassignExistingCard(vehicle.Veident, "");
            if (!forceDelete)
            {
                vehicle.Veend = DateTime.Now;
                _context.Vehicles.Update(vehicle);
            }
        }

        if (forceDelete)
        {
            _context.Vehicles.RemoveRange(vehicles);
        }
        await _context.SaveChangesAsync();
        return vehiclesToDelete;
    }
    public async Task DeleteDuplicates()
    {
        var duplicateVehicleIds = await _context.Vehicles
            .GroupBy(x => x.Veintno)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToListAsync();

        var duplicateVehicles = await _context.Vehicles
            .Where(e => duplicateVehicleIds.Contains(e.Veintno))
            .ToListAsync();

        foreach (var vehicle in duplicateVehicles)
        {
            await UnassignExistingCard(vehicle.Veident, "");
        }
        
        _context.Vehicles.RemoveRange(duplicateVehicles);
        await _context.SaveChangesAsync();
    }

    private async Task CreateVehicle(VehicleDto vehicle)
    {
        var newVehicle = new Vehicle()
        {
            Veintno = vehicle.RegistrationNumber,
            Vehhstart = vehicle.InitialCounter.GetValueOrDefault(),
            Vehours = vehicle.CurrentCounter.GetValueOrDefault(),
            Vetype = (byte)vehicle.VehicleCounterType,
            Vekmstart = vehicle.InitialKm.GetValueOrDefault(),
            Vemiles = vehicle.CurrentKm.GetValueOrDefault(),
            Veplate = vehicle.PlateNr,
            Vevehno = vehicle.VehicleIdNumber,
            Vedate = DateTime.Now,
            Vecat = Convert.ToInt32(vehicle.VehicleCategory),
        };
                
        _context.Vehicles.Add(newVehicle);
        await _context.SaveChangesAsync();
                
        var vtech = new Vtech()
        {
            Vtident = newVehicle.Veident,
            Vtdate = DateTime.Now,
        };
        _context.Vteches.Add(vtech);
                
        await UnassignExistingCard(newVehicle.Veident, vehicle.ChipCode);
        await AssignNewCard(newVehicle.Veident, vehicle.ChipCode);

        var existingConnection = await ConnectorExists(vehicle.VehicleCategory, vehicle.Id, null);
        if (existingConnection == null)
        {
            var connectedVehicle = CreateConnector(vehicle.VehicleCategory, vehicle.Id, newVehicle.Veident);
            if (connectedVehicle != null)
            {
                _connectorContext.Add(connectedVehicle);
            }
        }

        await _connectorContext.SaveChangesAsync();
    }

    private async Task UpdateVehicle(VehicleDto vehicle, Vehicle existingVehicle)
    {
        existingVehicle.Veintno = vehicle.RegistrationNumber;
        existingVehicle.Vehhstart = vehicle.InitialCounter.GetValueOrDefault();
        existingVehicle.Vehours = vehicle.CurrentCounter.GetValueOrDefault();
        existingVehicle.Vekmstart = vehicle.InitialKm.GetValueOrDefault();
        existingVehicle.Vemiles = vehicle.CurrentKm.GetValueOrDefault();
        existingVehicle.Vetype = (byte)vehicle.VehicleCounterType;
        existingVehicle.Veplate = vehicle.PlateNr;
        existingVehicle.Vevehno = vehicle.VehicleIdNumber;
        existingVehicle.Vedate = DateTime.Now;
        existingVehicle.Vecat = Convert.ToInt32(vehicle.VehicleCategory);
                
        await UnassignExistingCard(existingVehicle.Veident, vehicle.ChipCode);
        await AssignNewCard(existingVehicle.Veident, vehicle.ChipCode);
                
        var vtech = await _context.Vteches.FirstOrDefaultAsync(x => x.Vtident == existingVehicle.Veident);
        if (vtech != null)
        {
            _context.Vteches.Update(vtech);
        }
        _context.Vehicles.Update(existingVehicle);
    }
    private async Task SynchronizeIds(List<VehicleDto> vehicles)
    {
        var registrationNumbers = vehicles.Select(e => e.RegistrationNumber);
        var existingVehicles = await _context.Vehicles.Where(x => registrationNumbers.Contains(x.Veintno)).ToListAsync();
        foreach (var existingVehicle in existingVehicles)
        {
            var vehicle = vehicles.FirstOrDefault(x => x.RegistrationNumber == existingVehicle.Veintno);
            if (vehicle != null)
            {
                var existingConnection = await ConnectorExists(vehicle.VehicleCategory, vehicle.Id, null);
                if (existingConnection == null)
                {
                    var connectedVehicle = CreateConnector(vehicle.VehicleCategory, vehicle.Id, existingVehicle.Veident);
                    if (connectedVehicle != null)
                    {
                        _connectorContext.Add(connectedVehicle);
                    }
                }
            }
        }
        await _connectorContext.SaveChangesAsync();
    }
    private async Task<List<IConnector>> GetNovotecIds(List<VehicleDto> vehicles)
    {
        var allVehicleIds = new List<IConnector>();
        var vehicleIdentifiers = vehicles.Select(x => x.Id);
        var connectedVehicleIds = await _connectorContext.Vehicles.Where(x => vehicleIdentifiers.Contains(x.AgrarwareId)).ToListAsync();
        var connectedTractorIds = await _connectorContext.Tractors.Where(x => vehicleIdentifiers.Contains(x.AgrarwareId)).ToListAsync();
        var connectedGoodTransportIds = await _connectorContext.GoodsTransports.Where(x => vehicleIdentifiers.Contains(x.AgrarwareId)).ToListAsync();
        allVehicleIds.AddRange(connectedVehicleIds);
        allVehicleIds.AddRange(connectedTractorIds);
        allVehicleIds.AddRange(connectedGoodTransportIds);

        return allVehicleIds;
    }
    private async Task UnassignExistingCard(long vehicleId, string newCardNumber)
    {
        var existingCards = await _context.Cards.Where(x => x.Caveident == vehicleId).ToListAsync();
        foreach(var existingCard in existingCards)
        {
            // check here if this card is the one we want to assign
            if (existingCard.Cano != newCardNumber)
            {
                existingCard.Caveident = 0;

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

    private async Task AssignNewCard(long vehicleId, string cardNumber)
    {
        var newCard = await _context.Cards.FirstOrDefaultAsync(x => x.Cano == cardNumber);
        if (newCard != null)
        {
            // we probably need a check if this card was assigned to somebody else
            if (newCard.Caveident != vehicleId)
            {
                newCard.Caveident = vehicleId;
                
                _context.Cards.Update(newCard);
                
                await UpdateCardHistory(vehicleId, newCard.Caident);
                await SetCardActive(newCard.Caident);
            }
        }
        else if(!cardNumber.IsNullOrEmpty())
        {
            newCard = await _context.Cards.FirstOrDefaultAsync(x => x.Caveident == 0 && x.Catype == 0);
            if (newCard == null)
            {
                throw new ArgumentException("No unassigned cards left");
            }

            newCard.Cano = cardNumber;
            newCard.Cano2 = cardNumber;
            newCard.Caveident = vehicleId;
            
            _context.Cards.Update(newCard);

            await UpdateCardHistory(vehicleId, newCard.Caident);
            await SetCardActive(newCard.Caident);
        }
        await _context.SaveChangesAsync();
    }
    
    private async Task UpdateCardHistory(long vehicleId, long cardId)
    {
        var cardHistory = new Cahistory()
        {
            Chdate = DateTime.Now,
            Chveident = vehicleId,
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
        // otherwise should be some exception that maximum count is exceeded, probably
    }
    private static IConnector? CreateConnector(VehicleCategory category, string agrarwareId, long novotecId)
    {
        return category switch
        {
            VehicleCategory.Normal => new VehicleConnector
            {
                AgrarwareId = agrarwareId,
                NovotecId = novotecId
            },
            VehicleCategory.Tractor => new TractorConnector
            {
                AgrarwareId = agrarwareId,
                NovotecId = novotecId
            },
            VehicleCategory.GoodsTransport => new GoodsTransportConnector
            {
                AgrarwareId = agrarwareId,
                NovotecId = novotecId
            },
            _ => null
        };
    }
    private async Task<IConnector?> ConnectorExists(VehicleCategory category, string? agrarwareId, long? novotecId)
    {
        switch (category)
        {
            case VehicleCategory.Normal:
                if (agrarwareId != null)
                {
                    return await _connectorContext.Vehicles.FirstOrDefaultAsync(x => x.AgrarwareId == agrarwareId);
                }
                else
                {
                    return await _connectorContext.Vehicles.FirstOrDefaultAsync(x => x.NovotecId == novotecId);
                }

            case VehicleCategory.Tractor:
                if (agrarwareId != null)
                {
                    return await _connectorContext.Tractors.FirstOrDefaultAsync(x => x.AgrarwareId == agrarwareId);
                }
                else
                {
                    return await _connectorContext.Tractors.FirstOrDefaultAsync(x => x.NovotecId == novotecId);
                }

            case VehicleCategory.GoodsTransport:
                if (agrarwareId != null)
                {
                    return await _connectorContext.GoodsTransports.FirstOrDefaultAsync(x => x.AgrarwareId == agrarwareId);
                }
                else
                {
                    return await _connectorContext.GoodsTransports.FirstOrDefaultAsync(x => x.NovotecId == novotecId);
                }
            default:
                throw new InvalidOperationException($"Unknown category: {category}");
        }
    }
}
// var vehicle = new
// {
//     VEIDENT = 340,
//     VEDATE = "2024-12-03 09:09:46.477",
//     VEWHO = 40,
//     VEINTNO = "1-2-3-4-5",
//     VEVEHNO = string.Empty,
//     VEPLATE = "12345",
//     VEMEMO = string.Empty,
//     VEPBIDENT = 0,
//     VEPGIDENT = 0,
//     VESTART = "2024-12-04 00:00:00.000",
//     VEEND = (DateTime?)null,
//     VELEIDENT = 0,
//     VECOIDENT = 0,
//     VECC = string.Empty,
//     VEEMIDENT = 0,
//     VESTOC = string.Empty,
//     VESRIDENT = 0,
//     VEMILES = 1000,
//     VEHOURS = 0.00,
//     VETYPE = 1,
//     VEKMOFFSET = 445,
//     VEHHOFFSET = 0.00,
//     VEOFFDATE = "2024-11-03 00:00:00.000",
//     VEKMSTART = 555,
//     VEHHSTART = 0.00,
//     VEPLATE2 = "12345",
//     VESTATE = string.Empty,
//     VECOCODE = string.Empty,
//     VEHO = string.Empty,
//     VEDIVISION = string.Empty,
//     VEDIVABBR = string.Empty,
//     VEGROUP = string.Empty,
//     VECAT = 1
// };
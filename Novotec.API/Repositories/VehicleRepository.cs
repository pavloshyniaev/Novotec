using Microsoft.EntityFrameworkCore;
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
    private async Task SynchronizeIds(List<VehicleDto> vehicles)
    {
        var registrationNumbers = vehicles.Select(e => e.RegistrationNumber);
        var existingVehicles = await _context.Vehicles.Where(x => registrationNumbers.Contains(x.Veintno)).ToListAsync();
        foreach (var existingVehicle in existingVehicles)
        {
            var vehicle = vehicles.FirstOrDefault(x => x.RegistrationNumber == existingVehicle.Veintno);
            if (vehicle != null)
            {
                var existingConnection = await ConnectorExists(vehicle.VehicleCategory, vehicle.Id);
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
    public async Task AddOrUpdate(List<VehicleDto> vehicles)
    {
        await SynchronizeIds(vehicles);
        var novotecVehicleIds = await GetNovotecIds(vehicles);
        var existingVehicles = await _context.Vehicles.Where(x => novotecVehicleIds.Select(c => c.NovotecId).Contains(x.Veident)).ToListAsync(); 
        var vehiclesToDelete = await _context.Vehicles
            .Where(x => !novotecVehicleIds.Select(c => c.NovotecId).Contains(x.Veident))
            .ToListAsync();
        foreach (var vehicle in vehicles)
        {
            var vehicleNovotecId = novotecVehicleIds.FirstOrDefault(x => x.AgrarwareId == vehicle.Id)?.NovotecId;
            var existingVehicle = existingVehicles.FirstOrDefault(x => x.Veident == vehicleNovotecId);
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
                var newVehicle = new Vehicle()
                {
                    Veintno = vehicle.RegistrationNumber,
                    Vehhstart = vehicle.InitialCounter.GetValueOrDefault(),
                    Vehours = vehicle.CurrentCounter.GetValueOrDefault(),
                    Vekmstart = vehicle.InitialKm.GetValueOrDefault(),
                    Vemiles = vehicle.CurrentKm.GetValueOrDefault(),
                    Veplate = vehicle.PlateNr,
                    Vevehno = vehicle.VehicleIdNumber,
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

                var vehicleConnector = CreateConnector(vehicle.VehicleCategory, vehicle.Id, newVehicle.Veident);
                if(vehicleConnector != null)
                {
                    _connectorContext.Add(vehicleConnector);
                }

                await _connectorContext.SaveChangesAsync();
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

                existingVehicle.Veintno = vehicle.RegistrationNumber;
                existingVehicle.Vehhstart = vehicle.InitialCounter.GetValueOrDefault();
                existingVehicle.Vehours = vehicle.CurrentCounter.GetValueOrDefault();
                existingVehicle.Vekmstart = vehicle.InitialKm.GetValueOrDefault();
                existingVehicle.Vemiles = vehicle.CurrentKm.GetValueOrDefault();
                existingVehicle.Veplate = vehicle.PlateNr;
                existingVehicle.Vevehno = vehicle.VehicleIdNumber;
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
        }

        await DeleteVehicles(vehiclesToDelete, true);
        await _context.SaveChangesAsync();
    }

    public async Task<List<VehicleDto>> GetVehicles()
    {
        var currentTime = DateTime.Now;
        return await _context.Vehicles.Where(x => x.Veend < currentTime).Select(x => new VehicleDto(x)).ToListAsync();
    }
    public async Task DeleteVehicles(List<Vehicle> vehicles, bool forceDelete)
    {
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
    }
    private async Task UnassignExistingCard(long vehicleId, string newCardNumber)
    {
        var existingCard = await _context.Cards.FirstOrDefaultAsync(x => x.Caveident == vehicleId);
        if (existingCard != null && existingCard.Cano != newCardNumber)
        {
            existingCard.Caveident = 0;

            var cardHistory = new Cahistory()
            {
                Chdate = DateTime.Now,
                Chveident = 0,
                Chcaident = existingCard.Caident
            };
            _context.Cahistories.Add(cardHistory);

            var svAccount = await _context.Svaccounts.FirstOrDefaultAsync(x => x.Svcaident == existingCard.Caident);
            if (svAccount != null)
            {
                svAccount.Svcaident = 0;
                _context.Svaccounts.Update(svAccount);
            }

            _context.Cards.Update(existingCard);
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
                var cardHistory = new Cahistory()
                {
                    Chdate = DateTime.Now,
                    Chveident = vehicleId,
                    Chcaident = newCard.Caident
                };
                _context.Cahistories.Add(cardHistory);

                var svAccount = await _context.Svaccounts.FirstOrDefaultAsync(x => x.Svcaident == 0);
                if (svAccount != null)
                {
                    svAccount.Svcaident = newCard.Caident;
                    _context.Svaccounts.Update(svAccount);
                }
                // otherwise should be some exception that maximum count is exceeded, probably
                _context.Cards.Update(newCard);
            }
        }
        else
        {
            newCard = new Card()
            {
                Caveident = vehicleId,
                Cano = cardNumber,
                Cano2 = cardNumber,
                Catype = 0,
                Cadate = DateTime.Now
            };
            _context.Cards.Add(newCard);
            await _context.SaveChangesAsync();
            
            var cardHistory = new Cahistory()
            {
                Chdate = DateTime.Now,
                Chveident = vehicleId,
                Chcaident = newCard.Caident
            };
            _context.Cahistories.Add(cardHistory);

            var svAccount = await _context.Svaccounts.FirstOrDefaultAsync(x => x.Svcaident == 0);
            if (svAccount != null)
            {
                svAccount.Svcaident = newCard.Caident;
                _context.Svaccounts.Update(svAccount);
            }
            // otherwise should be some exception that maximum count is exceeded, probably
        }
        await _context.SaveChangesAsync();
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
    private async Task<IConnector?> ConnectorExists(VehicleCategory category, string agrarwareId)
    {
        switch (category)
        {
            case VehicleCategory.Normal:
                return await _connectorContext.Vehicles.FirstOrDefaultAsync(x => x.AgrarwareId == agrarwareId);

            case VehicleCategory.Tractor:
                return await _connectorContext.Tractors.FirstOrDefaultAsync(x => x.AgrarwareId == agrarwareId);

            case VehicleCategory.GoodsTransport:
                return await _connectorContext.GoodsTransports.FirstOrDefaultAsync(x => x.AgrarwareId == agrarwareId);

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
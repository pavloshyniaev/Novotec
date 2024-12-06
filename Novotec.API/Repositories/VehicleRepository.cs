using Microsoft.EntityFrameworkCore;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using NovotecDB;
using NovotecDB.Models;

namespace Novotec.API.Repositories;

public class VehicleRepository : IVehicleRepository
{
    private readonly NovotecContext _context;

    public VehicleRepository(NovotecContext context)
    {
        _context = context;
    }

    public async Task AddOrUpdate(List<VehicleDto> vehicles)
    {
        var vehicleIdentifiers = vehicles.Select(x => x.VehicleId);
        // using divabbr as unused field for synchronizing ids, as in agrarware we have separate tables for vehicle type
        var existingVehicles = await _context.Vehicles.Where(x => vehicleIdentifiers.Contains(x.Vedivabbr)).ToListAsync(); 
        var vehiclesToDelete = await _context.Vehicles
            .Where(x => !vehicleIdentifiers.Contains(x.Vedivabbr))
            .ToListAsync();
        foreach (var vehicleDto in vehicles)
        {
            var existingVehicle = existingVehicles.FirstOrDefault(x => x.Vedivabbr == vehicleDto.VehicleId);
            if (existingVehicle == null)
            {
                // DELETE FROM [dbo].[QUEUES] WHERE [QEIDENT]=203738
                // DELETE FROM [dbo].[CURRSTATUS] WHERE [CUIDENT]=62253
                // UPDATE [dbo].[CARDS] SET [CADATE]='20221108 12:35:56.000', [CAVEIDENT]=340 WHERE [CAIDENT]=185
                // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=185 WHERE [SVIDENT]=188
                // UPDATE [dbo].[WSTATION] SET [WSDATE]='20241203 09:15:05.887' WHERE [WSIDENT]=34
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241203 09:15:43.000' WHERE [CUIDENT]=62245
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241203 09:13:48.000' WHERE [CUIDENT]=62246
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241203 09:15:50.000', [CUMEMO]='COM port <3> could not be opened ' WHERE [CUIDENT]=62247
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241203 09:15:49.000' WHERE [CUIDENT]=62248
                // UPDATE [dbo].[CURRSTATUS] SET [CUDATE]='20241203 08:59:11.000' WHERE [CUIDENT]=62252
                // INSERT INTO [dbo].[CURRSTATUS] ([CUIDENT], [CUDATE], [CUTYPE], [CUPINFO], [CUSTATION], [CUPROGNO], [CUMESSID], [CUMESSAGE], [CUMEMO], [CUCRITICAL]) 
                // VALUES (62255, '20241203 09:12:59.000', 5, ' ', 'AGRARWARE', 9000001, 0, ' ', ' ', 0)
                // INSERT INTO [dbo].[RESPONSE] ([RSIDENT], [RSDATE], [RSORIDENT], [RSAUIDENT], [RSSTATE], [RSDATA], [RSRQNO]) 
                // VALUES (204841, '20241203 09:10:21.000', 185915, 1, 0, '340', 5010)
                // INSERT INTO [dbo].[VTECH] ([VTIDENT], [VTDATE], [VTWHO], [VTTANK], [VTNORM], [VTTYRESIZ1], [VTTYRESIZ2], [VTTYRESIZ3], [VTTYRESIZ4], [VTTYRESIZ5], [VTTYRESIZE], [VTSTEER1], [VTSTEER2], [VTSTEER3], [VTSTEER4], [VTSTEER5], [VTLIFT1], [VTLIFT2], [VTLIFT3], [VTLIFT4], [VTLIFT5], [VTTWIN1], [VTTWIN2], [VTTWIN3], [VTTWIN4], [VTTWIN5], [VTGVW], [VTSWL], [VTRET], [VTUNDA], [VTMOTOR], [VTMPOWER], [VTCYCLAP], [VTSEATS], [VTSTAND], [VTMEMO], [VTLOADAREA], [VTHOLD], [VTLOADH], [VTLOADW], [VTLOADL], [VTPOS], [VTNEG], [VTCO2], [VTDATEMAINT], [VTTANKVOLMINP], [VTTANKVOLMAXP], [VTTANKH2KG], [VTMINTEMP], [VTMAXTEMP], [VTMAXP], [VTMINP], [VTH2TYPE]) 
                // VALUES (340, '20241203 09:09:46.487', 40, 40, 9.0, '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 'Dienstag, 3. Dezember 2024 09:09', 0, 0, 0, 0, 0, 1.0, 1.0, 0, NULL, 0, 0, 0, 0, 0, 0, 0, 0)
                // INSERT INTO [dbo].[CAHISTORY] ([CHIDENT], [CHDATE], [CHWHO], [CHCAIDENT], [CHLEIDENT], [CHCOIDENT], [CHVEIDENT], [CHEMIDENT], [CHFCIDENT]) 
                // VALUES (842, '20241203 09:09:46.000', 41, 185, 0, 0, 340, 0, 0)
                // INSERT INTO [dbo].[VREFATT] ([VRIDENT], [VRVCIDENT], [VRVEIDENT]) 
                // VALUES (1, 1, 0)
                // INSERT INTO [dbo].[VREFATT] ([VRIDENT], [VRVCIDENT], [VRVEIDENT]) 
                // VALUES (2, 5, 0)
                // INSERT INTO [dbo].[ORDERS] ([ORIDENT], [ORDATE], [ORAUIDENT], [ORSTATE], [ORRQNO], [ORDATA], [ORERROR], [ORPROGNO], [ORCNT], [ORWHO], [ORSTART]) 
                // VALUES (185915, '20241203 09:10:20.927', 1, 0, 5010, '340', 0, 1, 0, 40, NULL)
                // INSERT INTO [dbo].[QUEUES] ([QEIDENT], [QEDATE], [QEORIDENT], [QEAUIDENT], [QESTATE], [QERQNO], [QEDATA], [QECNT], [QEBLOCKNO]) 
                // VALUES (203739, '20241203 09:10:20.990', 185915, 1, 1, 5010, 'V10018800000100<0******0003>80000000000N00000000000003>8', 0, -1)
                // INSERT INTO [dbo].[QUEUES] ([QEIDENT], [QEDATE], [QEORIDENT], [QEAUIDENT], [QESTATE], [QERQNO], [QEDATA], [QECNT], [QEBLOCKNO]) 
                // VALUES (203740, '20241203 09:10:21.000', 185915, 1, 1, 5010, 'Q1930,1,500', 0, -1)
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
                var vehicle = new Vehicle()
                {
                    Veintno = vehicleDto.RegistrationNumber,
                    Vehhstart = vehicleDto.InitialCounter.GetValueOrDefault(),
                    Vehours = vehicleDto.CurrentCounter.GetValueOrDefault(),
                    Vekmstart = vehicleDto.InitialKm.GetValueOrDefault(),
                    Vemiles = vehicleDto.CurrentKm.GetValueOrDefault(),
                    Veplate = vehicleDto.PlateNr,
                    Vecat = Convert.ToInt32(vehicleDto.VehicleCategory),
                };
                var vtech = new Vtech()
                {
                    Vtident = vehicle.Veident,
                    Vtdate = DateTime.Now,
                };
                
                _context.Vehicles.Add(vehicle);
            }
            else
            {
                // UPDATE [dbo].[VEHICLE] SET [VEDATE]='20241206 09:36:30.317', [VEWHO]=40, [VESTART]='20241206 00:00:00.000', [VEEND]='20241231 00:00:00.000', [VEMILES]=124100, [VEHOURS]=0.00, [VEKMOFFSET]=22, [VEOFFDATE]='20241206 00:00:00.000', [VESTATE]='gelöscht' WHERE [VEIDENT]=206
                // UPDATE [dbo].[CARDS] SET [CADATE]='20241206 09:36:30.327', [CAVEIDENT]=0 WHERE [CAIDENT]=261
                // UPDATE [dbo].[SVACCOUNT] SET [SVCAIDENT]=0 WHERE [SVIDENT]=249
                // UPDATE [dbo].[WSTATION] SET [WSDATE]='20241206 09:36:52.013' WHERE [WSIDENT]=34
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

                existingVehicle.Veintno = vehicleDto.RegistrationNumber;
                existingVehicle.Vehhstart = vehicleDto.InitialCounter.GetValueOrDefault();
                existingVehicle.Vehours = vehicleDto.CurrentCounter.GetValueOrDefault();
                existingVehicle.Vekmstart = vehicleDto.InitialKm.GetValueOrDefault();
                existingVehicle.Vemiles = vehicleDto.CurrentKm.GetValueOrDefault();
                existingVehicle.Veplate = vehicleDto.PlateNr;
                existingVehicle.Vecat = Convert.ToInt32(vehicleDto.VehicleCategory);

                _context.Vehicles.Update(existingVehicle);
            }
        }

        await _context.SaveChangesAsync();
    }

    public async Task<List<VehicleDto>> GetVehicles()
    {
        return await _context.Vehicles.Select(x => new VehicleDto(x)).ToListAsync();
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
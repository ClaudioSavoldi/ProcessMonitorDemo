using Microsoft.EntityFrameworkCore;
using ProcessMonitor.Data;
using ProcessMonitor.Enums;
using ProcessMonitor.Models;


namespace ProcessMonitorDemo.Services;

public class ProductionService
{
    private readonly AppDbContext _context;

    public ProductionService(AppDbContext context)
    {
        _context = context;
    }

    //get fasi produttive da db o dal metodo feed
    public async Task<List<ProductionStep>> GetProductionStepsAsync()
    {
        if (!await _context.ProductionSteps.AnyAsync())
        {
            await SeedProductionStepsAsync();
        }

        return await _context.ProductionSteps
            .OrderBy(step => step.Id)
            .ToListAsync();
    }

    //creare uno step 
    public async Task CreateProductionStepAsync(ProductionStep productionStep)
    {
        _context.ProductionSteps.Add(productionStep);

        await _context.SaveChangesAsync();
    }

    //seed di uno step
    private async Task SeedProductionStepsAsync()
    {
        var productionSteps = new List<ProductionStep>
        {
            new ProductionStep
            {
                Name = "Taglio",
                Machine = "Laser 01",
                Status = MachineStatus.Active,
                PiecesPerHour = 120,
                QueueCount = 3,
                Efficiency = 92
            },
            new ProductionStep
            {
                Name = "Assemblaggio",
                Machine = "Linea A",
                Status = MachineStatus.SlowedDown,
                PiecesPerHour = 55,
                QueueCount = 9,
                Efficiency = 64
            },
            new ProductionStep
            {
                Name = "Controllo qualità",
                Machine = "QC 02",
                Status = MachineStatus.Stopped,
                PiecesPerHour = 0,
                QueueCount = 6,
                Efficiency = 0
            },
            new ProductionStep
            {
                Name = "Imballaggio",
                Machine = "Pack 01",
                Status = MachineStatus.Active,
                PiecesPerHour = 100,
                QueueCount = 2,
                Efficiency = 88
            }
        };

        _context.ProductionSteps.AddRange(productionSteps);

        await _context.SaveChangesAsync();
    }
}
using ProcessMonitor.Models;

namespace ProcessMonitor.Services
{
    public class ProductionService
    {
        public List<ProductionStep> GetProductionSteps()
        {
            return new List<ProductionStep>
        {
            new ProductionStep
            {
                Name = "Taglio",
                Machine = "Laser 01",
                Status = "Attiva",
                PiecesPerHour = 120,
                QueueCount = 3,
                Efficiency = 92
            },
            new ProductionStep
            {
                Name = "Assemblaggio",
                Machine = "Linea A",
                Status = "Rallentata",
                PiecesPerHour = 55,
                QueueCount = 9,
                Efficiency = 64
            },
            new ProductionStep
            {
                Name = "Controllo qualità",
                Machine = "QC 02",
                Status = "Ferma",
                PiecesPerHour = 0,
                QueueCount = 6,
                Efficiency = 0
            },
            new ProductionStep
            {
                Name = "Imballaggio",
                Machine = "Pack 01",
                Status = "Attiva",
                PiecesPerHour = 100,
                QueueCount = 2,
                Efficiency = 88
            }
        };
        }
    }
}

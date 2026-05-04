using ProcessMonitor.Enums;

namespace ProcessMonitor.Models
{
    public class ProductionStep
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Machine { get; set; } = string.Empty;
        public MachineStatus Status { get; set; }
        public int PiecesPerHour { get; set; }
        public int QueueCount { get; set; }
        public int Efficiency { get; set; }

    }
}

namespace ProcessMonitor.Models
{
    public class ProductionStep
    {
        public string Name { get; set; } = string.Empty;
        public string Machine { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int PiecesPerHour { get; set; }
        public int QueueCount { get; set; }
        public int Efficiency { get; set; }

        
        

    }
}

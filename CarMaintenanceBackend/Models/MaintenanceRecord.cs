namespace CarMaintenanceBackend.Models
{
    public class MaintenanceRecord
    {
        public int Id { get; set; }

        public string CarModel { get; set; } = string.Empty;

        public string ServiceType { get; set; } = string.Empty;

        public DateTime ServiceDate { get; set; }

        public int Mileage { get; set; }

        public string Notes { get; set; } = string.Empty;
    }


}

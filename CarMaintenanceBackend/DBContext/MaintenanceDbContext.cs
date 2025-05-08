using CarMaintenanceBackend.Models;
using Microsoft.EntityFrameworkCore; // ✅ Required for DbContext and DbSet
using System.Collections.Generic;

namespace CarMaintenanceBackend.DBContext
{
    public class MaintenanceDbContext : DbContext
    {
        public MaintenanceDbContext(DbContextOptions<MaintenanceDbContext> options) : base(options) { }

        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
    }
}

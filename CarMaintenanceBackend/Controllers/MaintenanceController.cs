using CarMaintenanceBackend.DBContext;
using CarMaintenanceBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CarMaintenanceBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly MaintenanceDbContext _context;

        public MaintenanceController(MaintenanceDbContext context) => _context = context;

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] MaintenanceRecord record)
        {
            try
            {
                _context.MaintenanceRecords.Add(record);
                await _context.SaveChangesAsync();
                return Ok("Record added");
            }
            catch (Exception ex)
            {
                Console.WriteLine("POST ERROR: " + (ex.InnerException?.Message ?? ex.Message));
                return StatusCode(500, "Failed to add record: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MaintenanceRecord>>> GetAll()
        {
            try
            {
                var records = await _context.MaintenanceRecords.ToListAsync();
                return Ok(records);
            }
            catch (Exception ex)
            {
                Console.WriteLine("GET ERROR: " + (ex.InnerException?.Message ?? ex.Message));
                return StatusCode(500, "Failed to fetch records: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }


    }

}

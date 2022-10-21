using BE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MsStorageLocationController : ControllerBase
    {
        private readonly MegaCentralContext _context;

        public MsStorageLocationController(MegaCentralContext context)
        {
            _context = context;
        }

        // GET: api/MsStorageLocation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MsStorageLocation>>> GetMsStorageLocation()
        {
            return await _context.MsStorageLocations.ToListAsync();
        }
    }
}

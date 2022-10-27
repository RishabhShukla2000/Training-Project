using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Training_Project.Models;



namespace Training_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly TrainingProjectContext _context;

        public RolesController(TrainingProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Role>>> GetRoles()
        {
            return Ok(await _context.Roles.ToListAsync());
        }
    }
}

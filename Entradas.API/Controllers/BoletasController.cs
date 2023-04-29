using Entradas.API.Data;
using Entradas.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entradas.API.Controllers
{
    [ApiController]
    [Route("/api/boletas")]
    public class BoletasController : ControllerBase
    {
        private readonly DataContext _context;

        public BoletasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Boletas.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Boleta boleta)
        {
            _context.Add(boleta);
            await _context.SaveChangesAsync();
            return Ok(boleta);
        }
    }
}


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

       

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var boleta = await _context.Boletas.FirstOrDefaultAsync(x => x.Id == id);
            if (boleta is null)
            {
                return NotFound();
            }

            return Ok(boleta);
        }


        

        [HttpPut]
        public async Task<ActionResult> PutAsync(Boleta boleta)
        {
            
                _context.Update(boleta);
                await _context.SaveChangesAsync();
                return Ok(boleta);
            
        }
    }
}


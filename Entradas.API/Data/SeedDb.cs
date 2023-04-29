using Entradas.Shared.Entities;

namespace Entradas.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Boletas.Any())
            {
                for(int i=0;i<50000;i++)
                {
                    _context.Boletas.Add(new Boleta { Usada = false });
                }
                
               
            }

            await _context.SaveChangesAsync();
        }
    }

}

using DGIIApp.Data;
using DGIIApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DGIIApp.Services
{
    public class ContribuyenteService : IContribuyenteService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ContribuyenteService> _logger;

        public ContribuyenteService(AppDbContext context)
        {
            _context = context;
        }

        public ContribuyenteService(AppDbContext context, ILogger<ContribuyenteService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Contribuyente>> GetAllAsync()
        {
            try
            {
                _logger.LogInformation("Obteniendo listado de contribuyentes...");
                return await _context.Contribuyentes.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el listado de contribuyentes.");
                throw;
            }
        }
    }
}

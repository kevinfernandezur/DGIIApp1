using DGIIApp.Data;
using DGIIApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DGIIApp.Services
{
    public class ComprobanteService : IComprobanteService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ComprobanteService> _logger;

        public ComprobanteService(AppDbContext context)
        {
            _context = context;
        }

        public ComprobanteService(AppDbContext context, ILogger<ComprobanteService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<ComprobanteFiscal>> GetAllAsync()
        {
            try
            {
                _logger.LogInformation("Obteniendo todos los comprobantes fiscales...");
                return await _context.Comprobantes.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener todos los comprobantes fiscales.");
                throw;
            }
        }

        public async Task<decimal> GetTotalItbisByRncAsync(string rnc)
        {
            try
            {
                _logger.LogInformation("Calculando total de ITBIS para RNC/Cédula: {rnc}", rnc);
                return await _context.Comprobantes
                    .Where(c => c.RncCedula == rnc)
                    .SumAsync(c => c.Itbis18);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al calcular el total de ITBIS para el RNC/Cédula: {rnc}", rnc);
                throw;
            }
        }
    }
}

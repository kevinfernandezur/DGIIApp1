using DGIIApp.Models;

namespace DGIIApp.Services
{
    public interface IComprobanteService
    {
        Task<List<ComprobanteFiscal>> GetAllAsync();
        Task<decimal> GetTotalItbisByRncAsync(string rnc);
    }
}

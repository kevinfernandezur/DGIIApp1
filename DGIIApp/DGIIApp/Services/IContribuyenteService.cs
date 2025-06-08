using DGIIApp.Models;

namespace DGIIApp.Services
{
    public interface IContribuyenteService
    {
        Task<List<Contribuyente>> GetAllAsync();
    }
}

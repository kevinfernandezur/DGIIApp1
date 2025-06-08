using DGIIApp.Models;
using DGIIApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DGIIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComprobantesController : ControllerBase
    {
        private readonly IComprobanteService _service;

        public ComprobantesController(IComprobanteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComprobanteFiscal>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{rncCedula}/itbis")]
        public async Task<ActionResult<decimal>> GetItbisPorRNC(string rncCedula)
        {
            var total = await _service.GetTotalItbisByRncAsync(rncCedula);
            return Ok(total);
        }
    }
}

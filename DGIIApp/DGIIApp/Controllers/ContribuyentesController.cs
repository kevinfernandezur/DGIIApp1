using DGIIApp.Models;
using DGIIApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DGIIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContribuyentesController : ControllerBase
    {
        private readonly IContribuyenteService _service;

        public ContribuyentesController(IContribuyenteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contribuyente>>> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("error-test")]
        public IActionResult ProbarExcepcion()
        {
            throw new Exception("No se pudo completar la operación solicitada. Por favor, intente nuevamente o contacte al administrador del sistema si el problema persiste.");
        }

    }
}

using CaadTec.Core.DTO_s;
using CaadTec.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace CaadTec.API.Controllers
{
    [ApiController]
    [EnableCors("MyCors")]
    [Route("api/Factura")]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _facturaService;
        List<string> messages = new List<string>();
        private IConfiguration _config;

        public FacturaController(IFacturaService facturaService, IConfiguration config)
        {
            _facturaService = facturaService;
            _config = config;
        }
        [HttpPost("AddFactura")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FacturaDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Dictionary<string, object>))]
        [SwaggerOperation
            (
             Summary = "Add Factura",
             Description = "Add Factura"
             )]
        public async Task<IActionResult> AddFactura(FacturaDTO facturasDTO)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _facturaService.AddFactura(facturasDTO);
                if(result == null)
                {
                    messages.Add("Error");
                    return BadRequest(messages);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                messages.Add(ex.Message.ToString());
                return StatusCode(StatusCodes.Status501NotImplemented, ex.Message);
            }
        }
    }
}

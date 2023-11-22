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
    [Route("api/Pedido")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        List<string> messages = new List<string>();
        private IConfiguration _config;

        public PedidoController(IPedidoService pedidoService, IConfiguration config)
        {
            _pedidoService = pedidoService;
            _config = config;
        }
        [HttpPost("AddPedidos")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PedidoDTO))]
        [SwaggerOperation
            (
            Summary = "Add Pedido",
            Description = "Add Pedido"
            )]

        public async Task<IActionResult> AddPedido(PedidoDTO pedidoDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _pedidoService.AddPedido(pedidoDTO);
                if(result == null)
                {
                    return BadRequest(messages);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status501NotImplemented, ex.Message);
            }
        }

    }
}

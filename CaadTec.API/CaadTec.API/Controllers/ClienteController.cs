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
    [Route("api/Cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        List<string> messages = new List<string>();
        private IConfiguration _config;

        public ClienteController(IClienteService clienteService, IConfiguration config)
        {
            _clienteService = clienteService;
            _config = config;
        }
        [HttpPost("AddClientes")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClienteDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Dictionary<string, object>))]
        [SwaggerOperation
            (
             Summary = "Add CLiente",
             Description = "Add Cliente" 
             )]
        public async Task<IActionResult> AddClientes(ClienteDTO clienteDTO)
        {
            try
            {
              if(!ModelState.IsValid)
              {
                  return BadRequest(ModelState);
              }
              var result = await _clienteService.AddClientes(clienteDTO);
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

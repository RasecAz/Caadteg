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
    [Route("api/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        List<string> messages = new List<string>();
        private IConfiguration _config;

        public UsuarioController(IUsuarioService usuarioService, IConfiguration config)
        {
            _usuarioService = usuarioService;
            _config = config;
        }

        [HttpPost("AddUsuarios")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
        [SwaggerOperation
            (
            Summary = "Add Usuario",
            Description = "Add Usuario"
            )]

        public async Task<IActionResult> AddUsauarios(UsuarioDTO usuarioDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _usuarioService.AddUsauarios(usuarioDTO);
                if (result == null)
                {
                    messages.Add("Error");
                    return BadRequest(ModelState);
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

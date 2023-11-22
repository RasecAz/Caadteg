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
    [Route("api/Producto")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        List<string> messages = new List<string>();
        private IConfiguration _config;

        public ProductoController(IProductoService productoService, IConfiguration config)
        {
            _config = config;
            _productoService = productoService;
        }

        [HttpPost("AddProductos")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
        [SwaggerOperation
            (
            Summary = "Add Producto",
            Description = "Add Producto"
            )
        ]

        public async Task<IActionResult> AddProductos(ProductoDTO productoDTO)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var resutl = await _productoService.AddProductos(productoDTO);
                if(resutl == null)
                {
                    return BadRequest(messages); 
                }
                return Ok(resutl);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status501NotImplemented, ex.Message);
            }
        }

    }
}

using CaadTec.Core.DTO_s;
using CaadTec.Core.Entities;
using CaadTec.Core.Interfaces.IServices;
using CaadTec.Core.Interfaces.Repositories;

namespace CaadTec.Core.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IAsyncRepository<Productos> _asyncRepository;
        public ProductoService(IAsyncRepository<Productos> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }

        public async Task<Productos> AddProductos(ProductoDTO productoDTO)
        {
            var productos = new Productos
            {
                Nombre = productoDTO.Nombre,
                Descripcion = productoDTO.Descripcion,
                Fecha_ingreso = productoDTO.Fecha_ingreso,
                Cantidad = productoDTO.Cantidad
            };
            return await _asyncRepository.AddAsync(productos);
        }
    }
}

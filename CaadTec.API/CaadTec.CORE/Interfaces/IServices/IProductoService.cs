using CaadTec.Core.DTO_s;
using CaadTec.Core.Entities;

namespace CaadTec.Core.Interfaces.IServices
{
    public interface IProductoService
    {
        Task<Productos> AddProductos(ProductoDTO productoDTO);
    }
}

using CaadTec.Core.DTO_s;
using CaadTec.Core.Entities;
using CaadTec.Core.Interfaces.IServices;
using CaadTec.Core.Interfaces.Repositories;

namespace CaadTec.Core.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IAsyncRepository<Pedidos> _asyncRepository;

        public PedidoService(IAsyncRepository<Pedidos> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }
        public async Task<Pedidos> AddPedido(PedidoDTO pedidoDTO)
        {
            var pedidos = new Pedidos
            {
                Descripcion = pedidoDTO.Descripcion,
                Fecha_pedido = pedidoDTO.Fecha_pedido,
                Cantidad = pedidoDTO.Cantidad,
                Nombre_producto = pedidoDTO.Nombre_producto,
            };
            return await _asyncRepository.AddAsync(pedidos);
        }
    }
}

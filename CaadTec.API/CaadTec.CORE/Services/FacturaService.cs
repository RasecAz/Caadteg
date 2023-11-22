using CaadTec.Core.DTO_s;
using CaadTec.Core.Entities;
using CaadTec.Core.Interfaces.IServices;
using CaadTec.Core.Interfaces.Repositories;

namespace CaadTec.Core.Services
{
    public class FacturaService : IFacturaService
    {
        private readonly IAsyncRepository<Facturas> _asyncRepository;

        public FacturaService(IAsyncRepository<Facturas> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }

        public async Task<Facturas> AddFactura(FacturaDTO facturasDTO)
        {
            var facturas = new Facturas
            {
                Cantidad_productos = facturasDTO.Cantidad_productos,
                Total = facturasDTO.Total,
                Num_fac = facturasDTO.Num_fac
            };
            return await _asyncRepository.AddAsync(facturas);
        }
    }
}

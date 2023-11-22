using CaadTec.Core.DTO_s;
using CaadTec.Core.Entities;
using CaadTec.Core.Interfaces.IServices;
using CaadTec.Core.Interfaces.Repositories;

namespace CaadTec.Core.Services
{
    public class ClienteServices : IClienteService
    {
        private readonly IAsyncRepository<Cliente>  _asyncRepository;

        public ClienteServices(IAsyncRepository<Cliente> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }
        public async Task<Cliente> AddClientes(ClienteDTO clienteDTO)
        {
            var clientes = new Cliente
            {
                Nombre = clienteDTO.Nombre,
                Telefono = clienteDTO.Telefono
            };

            return await _asyncRepository.AddAsync(clientes);
        }
    }
}

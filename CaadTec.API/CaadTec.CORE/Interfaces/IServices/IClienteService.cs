using CaadTec.Core.DTO_s;
using CaadTec.Core.Entities;

namespace CaadTec.Core.Interfaces.IServices
{
    public interface IClienteService
    {
        Task<Cliente> AddClientes(ClienteDTO clienteDTO);
    }
}

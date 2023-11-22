using CaadTec.Core.DTO_s;
using CaadTec.Core.Entities;
using CaadTec.Core.Interfaces.IServices;
using CaadTec.Core.Interfaces.Repositories;

namespace CaadTec.Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IAsyncRepository<Usuarios> _asyncRepository;
        public UsuarioService(IAsyncRepository<Usuarios> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }
        public async Task<Usuarios> AddUsauarios(UsuarioDTO usuarioDTO)
        {
            var usuarios = new Usuarios
            {
                Nombre = usuarioDTO.Nombre,
                Telefono = usuarioDTO.Telefono,
                Correo = usuarioDTO.Correo,
            };
            return await _asyncRepository.AddAsync(usuarios);
        }
    }
}

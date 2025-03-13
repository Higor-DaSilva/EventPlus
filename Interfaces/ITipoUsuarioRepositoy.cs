using EventPlus.Domains;
using Microsoft.EntityFrameworkCore;

namespace EventoPlus.Interfaces
{
    public interface ITipoUsuarioRepositoy
    {
        void Cadastrar(TipoUsuario tipoUsuario);

        List<TipoUsuario> Listar();
        
        void Atualizar(Guid id, TipoUsuario tipoUsuario);

        void Deletar(Guid id);

        void BuscarUsuarioPorId(Guid id);
    }
}

using EventoPlus.Context;
using EventoPlus.Interfaces;
using EventPlus.Domains;

namespace EventoPlus.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly EventPlus_Context _context;
        public TipoUsuarioRepository(EventPlus_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {
            TipoUsuario usuarioBuscado = _context.TipoUsuario.Find(id)!;

            if (usuarioBuscado != null)
            {
                usuarioBuscado.TituloTipoUsuario = tipoUsuario.TituloTipoUsuario;
            }
            _context.SaveChanges();
        }

        public void BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}

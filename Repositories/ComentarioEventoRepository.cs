using EventoPlus.Context;
using EventoPlus.Interfaces;
using EventPlus.Domains;

namespace EventoPlus.Repositories
{
    public class ComentarioEventoRepository : IComentarioEventosRepository
    {
        private readonly EventPlus_Context _context;
        public ComentarioEventoRepository(EventPlus_Context context)
        {
            _context = context;
        }

        public ComentarioEvento BuscarPorIdUsuario(Guid idUsuario, Guid IdEvento)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ComentarioEvento novoComentario)
        {
            try
            {
                _context.ComentarioEvento.Add(novoComentario);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                ComentarioEvento eventoBuscado = _context.ComentarioEvento.Find(id)!;

                if (eventoBuscado != null)
                {
                    _context.ComentarioEvento.Remove(eventoBuscado);
                }
                _context.SaveChanges();
            }

            catch (Exception)
            {

                throw;
            }
        }
        


        public List<ComentarioEvento> Listar()
        {
            List<ComentarioEvento> Lista = _context.ComentarioEvento.ToList();
            return Lista;
        }
    }
}

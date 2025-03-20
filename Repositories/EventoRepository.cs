using EventoPlus.Context;
using EventoPlus.Interfaces;
using EventPlus.Domains;

namespace EventoPlus.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventPlus_Context _context;
        public EventoRepository(EventPlus_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Evento evento)
        {
            Evento eventoBuscado = _context.Evento.Find(id)!;

            if (eventoBuscado != null)
            {
                eventoBuscado.DataEvento = evento.DataEvento;
                eventoBuscado.NomeEvento = evento.NomeEvento;
                eventoBuscado.Descricao = evento.Descricao;
            }
            _context.SaveChanges();
        }

        public Evento BuscarPorId(Guid id)
        {
            try
            {
                Evento eventoBuscado = _context.Evento.Find(id)!;

                return eventoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Evento novoEvento)
        {
            try
            {
                _context.Evento.Add(novoEvento);

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
                Evento eventoBuscado = _context.Evento.Find(id)!;

                if (eventoBuscado != null)
                {
                    _context.Evento.Remove(eventoBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Evento> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Evento> ListarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> ProximosEventos()
        {
            throw new NotImplementedException();
        }
    }
}

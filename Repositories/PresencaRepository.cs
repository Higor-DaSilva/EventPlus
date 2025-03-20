using EventoPlus.Context;
using EventoPlus.Interfaces;
using EventPlus.Domains;
using Microsoft.EntityFrameworkCore;

namespace EventoPlus.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {
        private readonly EventPlus_Context _context;
        public PresencaRepository(EventPlus_Context context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, Presenca presenca)
        {
            Presenca presencaBuscada = _context.Presenca.Find(id)!;

            if (presencaBuscada != null)
            {
                presencaBuscada.Situacao = presenca.Situacao;
            }
            _context.SaveChanges();
        }

        public Presenca BuscarPorId(Guid id)
        {
            try
            {
                Presenca usuarioBuscado = _context.Presenca.Find(id)!;

                return usuarioBuscado;
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
                Presenca eventoBuscado = _context.Presenca.Find(id)!;

                if (eventoBuscado != null)
                {
                    _context.Presenca.Remove(eventoBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Inscrever(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Presenca> Listar()
        {
            List<Presenca> Lista = _context.Presenca.ToList();
            return Lista;
        }

        public List<Presenca> ListarMinhas(Guid id)
        {
            List<Presenca> Listaminhas = _context.Presenca.ToList()!;
            return Listaminhas;
        }
    }
}

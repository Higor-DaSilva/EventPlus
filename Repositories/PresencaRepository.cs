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
            try
            {
                Presenca presencaBuscado = _context.Presenca.Find(id)!;
                if (presencaBuscado != null)
                {
                    presencaBuscado.Situacao = presenca.Situacao;
                }
                int v = _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Presenca BuscarPorId(Guid id)
        {
            try
            {
                Presenca presencaBuscada = _context.Presenca.Find(id)!;
                return presencaBuscada;
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
                Presenca presencaBuscada = _context.Presenca.Find(id)!;
                if (presencaBuscada != null)
                {
                    _context.Presenca.Remove(presencaBuscada);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Inscrever(Presenca novaPresenca)
        {
             try
            {
                _context.Presenca.Add(novaPresenca);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Presenca> Listar()
        {
            try
            {
                List<Presenca> listaPresenca = _context.Presenca.ToList();
                return listaPresenca;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Presenca> ListarMinhas(Guid id)
        {
            try
            {
                List<Presenca> listaPresenca = _context.Presenca.Where(p => p.IdUsuario == id).ToList();
                return listaPresenca;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

using System.Runtime.CompilerServices;
using EventoPlus.Context;
using EventoPlus.Interfaces;
using EventoPlus.Utils;
using EventPlus.Domains;

namespace EventoPlus.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventPlus_Context _context;

        public Usuario BuscarPorEmailESenha(Guid id, string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }

                return null!;
            }

            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                return usuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            _context.Usuario.Add(novoUsuario);
            _context.SaveChanges();
        }
    }
}

using college_management.Dados.Repositorios;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Servicos
{
    public class AutenticacaoServico
    {
        private readonly RepositorioBase<Usuario> _repositorioUsuarios;

        public AutenticacaoServico(RepositorioBase<Usuario> repositorioUsuarios)
        {
            _repositorioUsuarios = repositorioUsuarios;
        }

        public async Task<Usuario?> AutenticarAsync(string login, string senha)
        {
            var usuario = await _repositorioUsuarios.ObterAsync(u => u.Login == login && u.Senha == senha);
            return usuario;
        }

        public bool VerificarPermissao(Usuario usuario, TipoUsuario tipoRequerido)
        {
            return usuario.Tipo == tipoRequerido;
        }
    }
} 
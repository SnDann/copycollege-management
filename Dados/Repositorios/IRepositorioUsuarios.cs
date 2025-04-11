using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioUsuarios : IRepositorioBase<Usuario>
    {
        Task<Usuario> ObterPorLoginAsync(string login);
        Task<bool> ValidarCredenciaisAsync(string login, string senha);
    }
} 
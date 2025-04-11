using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioBase<T> where T : class
    {
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<T> ObterPorIdAsync(int id);
        Task<bool> ExisteAsync(int id);
        Task AdicionarAsync(T entity);
        Task AtualizarAsync(T entity);
        Task RemoverAsync(T entity);
    }
} 
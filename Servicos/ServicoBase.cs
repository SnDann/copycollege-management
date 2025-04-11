using college_management.Dados;
using college_management.Models;

namespace college_management.Servicos
{
    public interface IServico<T> where T : class
    {
        Task<T?> ObterPorIdAsync(int id);
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<T> AdicionarAsync(T entity);
        Task<T> AtualizarAsync(T entity);
        Task<bool> RemoverAsync(int id);
    }

    public class ServicoBase<T> : IServico<T> where T : class
    {
        protected readonly IRepositorio<T> _repositorio;

        public ServicoBase(IRepositorio<T> repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual async Task<T?> ObterPorIdAsync(int id)
        {
            return await _repositorio.ObterPorIdAsync(id);
        }

        public virtual async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _repositorio.ObterTodosAsync();
        }

        public virtual async Task<T> AdicionarAsync(T entity)
        {
            return await _repositorio.AdicionarAsync(entity);
        }

        public virtual async Task<T> AtualizarAsync(T entity)
        {
            return await _repositorio.AtualizarAsync(entity);
        }

        public virtual async Task<bool> RemoverAsync(int id)
        {
            return await _repositorio.RemoverAsync(id);
        }
    }
} 
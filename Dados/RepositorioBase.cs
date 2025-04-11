using Microsoft.EntityFrameworkCore;
using college_management.Contextos;
using college_management.Models;

namespace college_management.Dados
{
    public interface IRepositorio<T> where T : class
    {
        Task<T?> ObterPorIdAsync(int id);
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<T> AdicionarAsync(T entity);
        Task<T> AtualizarAsync(T entity);
        Task<bool> RemoverAsync(int id);
    }

    public class RepositorioBase<T> : IRepositorio<T> where T : class
    {
        protected readonly CollegeDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositorioBase(CollegeDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T?> ObterPorIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> AdicionarAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> AtualizarAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> RemoverAsync(int id)
        {
            var entity = await ObterPorIdAsync(id);
            if (entity == null)
                return false;

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
} 
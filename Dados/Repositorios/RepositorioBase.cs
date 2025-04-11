using college_management.Contextos;
using Microsoft.EntityFrameworkCore;

namespace college_management.Dados.Repositorios
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        protected readonly CollegeDbContext _context;
        protected readonly DbSet<T> _dbSet;

        protected RepositorioBase(CollegeDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> ObterPorIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> ExisteAsync(int id)
        {
            return await _dbSet.FindAsync(id) != null;
        }

        public virtual async Task AdicionarAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task AtualizarAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task RemoverAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
} 
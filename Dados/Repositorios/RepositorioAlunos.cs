using college_management.Contextos;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Dados.Repositorios
{
    public class RepositorioAlunos : RepositorioBase<Aluno>, IRepositorioAlunos
    {
        public RepositorioAlunos(CollegeDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Aluno>> ObterPorCursoAsync(int cursoId)
        {
            return await _dbSet
                .Where(a => a.CursoId == cursoId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Aluno>> ObterPorTurmaAsync(int turmaId)
        {
            return await _dbSet
                .Where(a => a.Matriculas.Any(m => m.TurmaId == turmaId))
                .ToListAsync();
        }

        public async Task<IEnumerable<Matricula>> ObterMatriculasAsync(int alunoId)
        {
            return await _context.Matriculas
                .Where(m => m.AlunoId == alunoId)
                .ToListAsync();
        }
    }
} 
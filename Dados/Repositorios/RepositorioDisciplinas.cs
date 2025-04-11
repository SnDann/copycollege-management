using college_management.Contextos;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Dados.Repositorios
{
    public class RepositorioDisciplinas : RepositorioBase<Disciplina>, IRepositorioDisciplinas
    {
        public RepositorioDisciplinas(CollegeDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Turma>> ObterTurmasAsync(int disciplinaId)
        {
            return await _context.Turmas
                .Where(t => t.DisciplinaId == disciplinaId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Professor>> ObterProfessoresAsync(int disciplinaId)
        {
            return await _context.Professores
                .Where(p => p.Turmas.Any(t => t.DisciplinaId == disciplinaId))
                .ToListAsync();
        }
    }
} 
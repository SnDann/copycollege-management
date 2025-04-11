using college_management.Contextos;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Dados.Repositorios
{
    public class RepositorioProfessores : RepositorioBase<Professor>, IRepositorioProfessores
    {
        public RepositorioProfessores(CollegeDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Turma>> ObterTurmasAsync(int professorId)
        {
            return await _context.Turmas
                .Where(t => t.ProfessorId == professorId)
                .Include(t => t.Disciplina)
                .ToListAsync();
        }

        public async Task<IEnumerable<Disciplina>> ObterDisciplinasAsync(int professorId)
        {
            return await _context.Disciplinas
                .Where(d => d.Turmas.Any(t => t.ProfessorId == professorId))
                .ToListAsync();
        }
    }
} 
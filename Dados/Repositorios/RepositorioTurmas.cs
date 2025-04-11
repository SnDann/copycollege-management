using Microsoft.EntityFrameworkCore;
using college_management.Contextos;
using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public class RepositorioTurmas : RepositorioBase<Turma>
    {
        public RepositorioTurmas(CollegeDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Turma>> ObterTurmasPorDisciplinaAsync(int disciplinaId)
        {
            return await _dbSet
                .Include(t => t.Professor)
                .Include(t => t.Disciplina)
                .Where(t => t.DisciplinaId == disciplinaId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Turma>> ObterTurmasPorProfessorAsync(int professorId)
        {
            return await _dbSet
                .Include(t => t.Disciplina)
                .Include(t => t.Matriculas)
                .Where(t => t.ProfessorId == professorId)
                .ToListAsync();
        }

        public async Task<bool> VerificarVagasDisponiveisAsync(int turmaId)
        {
            var turma = await _dbSet
                .Include(t => t.Matriculas)
                .FirstOrDefaultAsync(t => t.Id == turmaId);

            if (turma == null)
                return false;

            return turma.VagasDisponiveis > 0;
        }

        public async Task<bool> AtualizarVagasAsync(int turmaId)
        {
            var turma = await _dbSet
                .Include(t => t.Matriculas)
                .FirstOrDefaultAsync(t => t.Id == turmaId);

            if (turma == null)
                return false;

            turma.VagasDisponiveis = turma.Vagas - turma.Matriculas.Count;
            await _context.SaveChangesAsync();
            return true;
        }
    }
} 
using college_management.Contextos;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Dados.Repositorios
{
	public class RepositorioMatriculas : RepositorioBase<Matricula>, IRepositorioMatriculas
	{
		public RepositorioMatriculas(CollegeDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Matricula>> ObterPorAlunoAsync(int alunoId)
		{
			return await _context.Matriculas
				.Where(m => m.AlunoId == alunoId)
				.Include(m => m.Turma)
				.ThenInclude(t => t.Disciplina)
				.ToListAsync();
		}

		public async Task<IEnumerable<Matricula>> ObterPorTurmaAsync(int turmaId)
		{
			return await _context.Matriculas
				.Where(m => m.TurmaId == turmaId)
				.Include(m => m.Aluno)
				.ToListAsync();
		}

		public async Task<bool> AlunoJaMatriculadoAsync(int alunoId, int turmaId)
		{
			return await _dbSet
				.AnyAsync(m => m.AlunoId == alunoId && m.TurmaId == turmaId);
		}
	}
}

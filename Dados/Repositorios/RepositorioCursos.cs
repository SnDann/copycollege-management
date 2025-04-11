using college_management.Contextos;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Dados.Repositorios
{
	public class RepositorioCursos : RepositorioBase<Curso>, IRepositorioCursos
	{
		public RepositorioCursos(CollegeDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Disciplina>> ObterDisciplinasAsync(int cursoId)
		{
			return await _context.Disciplinas
				.Where(d => d.CursoId == cursoId)
				.ToListAsync();
		}

		public async Task<IEnumerable<Aluno>> ObterAlunosAsync(int cursoId)
		{
			return await _context.Alunos
				.Where(a => a.CursoId == cursoId)
				.ToListAsync();
		}

		public override async Task<bool> ExisteAsync(int id)
		{
			var curso = await _dbSet.FindAsync(id);
			if (curso == null) return false;

			return await _dbSet.AnyAsync(c => c.Nome == curso.Nome && c.Id != id);
		}
	}
}

using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioCursos : IRepositorioBase<Curso>
    {
        Task<IEnumerable<Disciplina>> ObterDisciplinasAsync(int cursoId);
        Task<IEnumerable<Aluno>> ObterAlunosAsync(int cursoId);
    }
} 
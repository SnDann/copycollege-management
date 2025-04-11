using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioAlunos : IRepositorioBase<Aluno>
    {
        Task<IEnumerable<Aluno>> ObterPorCursoAsync(int cursoId);
        Task<IEnumerable<Aluno>> ObterPorTurmaAsync(int turmaId);
        Task<IEnumerable<Matricula>> ObterMatriculasAsync(int alunoId);
    }
} 
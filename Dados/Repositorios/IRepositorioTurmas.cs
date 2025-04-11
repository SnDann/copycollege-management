using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioTurmas : IRepositorioBase<Turma>
    {
        Task<IEnumerable<Matricula>> ObterMatriculasAsync(int turmaId);
        Task<bool> TemVagasAsync(int turmaId);
    }
} 
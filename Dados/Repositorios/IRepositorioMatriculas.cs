using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioMatriculas : IRepositorioBase<Matricula>
    {
        Task<IEnumerable<Matricula>> ObterPorAlunoAsync(int alunoId);
        Task<IEnumerable<Matricula>> ObterPorTurmaAsync(int turmaId);
    }
} 
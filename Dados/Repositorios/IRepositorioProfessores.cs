using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioProfessores : IRepositorioBase<Professor>
    {
        Task<IEnumerable<Turma>> ObterTurmasAsync(int professorId);
    }
} 
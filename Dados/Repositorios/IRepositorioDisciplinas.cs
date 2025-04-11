using college_management.Models;

namespace college_management.Dados.Repositorios
{
    public interface IRepositorioDisciplinas : IRepositorioBase<Disciplina>
    {
        Task<IEnumerable<Turma>> ObterTurmasAsync(int disciplinaId);
    }
} 
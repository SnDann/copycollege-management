using college_management.Dados.Repositorios;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Servicos
{
    public class AcademicoServico
    {
        private readonly RepositorioBase<Curso> _repositorioCursos;
        private readonly RepositorioBase<Disciplina> _repositorioDisciplinas;

        public AcademicoServico(
            RepositorioBase<Curso> repositorioCursos,
            RepositorioBase<Disciplina> repositorioDisciplinas)
        {
            _repositorioCursos = repositorioCursos;
            _repositorioDisciplinas = repositorioDisciplinas;
        }

        // Métodos para Cursos
        public async Task<IEnumerable<Curso>> ListarCursosAsync()
        {
            return await _repositorioCursos.ListarAsync();
        }

        public async Task<Curso?> ObterCursoAsync(int id)
        {
            return await _repositorioCursos.ObterAsync(c => c.Id == id);
        }

        public async Task<bool> CriarCursoAsync(Curso curso)
        {
            return await _repositorioCursos.AdicionarAsync(curso);
        }

        public async Task<bool> AtualizarCursoAsync(Curso curso)
        {
            return await _repositorioCursos.AtualizarAsync(curso);
        }

        public async Task<bool> ExcluirCursoAsync(int id)
        {
            return await _repositorioCursos.ExcluirAsync(id);
        }

        // Métodos para Disciplinas
        public async Task<IEnumerable<Disciplina>> ListarDisciplinasAsync()
        {
            return await _repositorioDisciplinas.ListarAsync();
        }

        public async Task<IEnumerable<Disciplina>> ListarDisciplinasPorCursoAsync(int cursoId)
        {
            return await _repositorioDisciplinas.ListarAsync(d => d.CursoId == cursoId);
        }

        public async Task<Disciplina?> ObterDisciplinaAsync(int id)
        {
            return await _repositorioDisciplinas.ObterAsync(d => d.Id == id);
        }

        public async Task<bool> CriarDisciplinaAsync(Disciplina disciplina)
        {
            return await _repositorioDisciplinas.AdicionarAsync(disciplina);
        }

        public async Task<bool> AtualizarDisciplinaAsync(Disciplina disciplina)
        {
            return await _repositorioDisciplinas.AtualizarAsync(disciplina);
        }

        public async Task<bool> ExcluirDisciplinaAsync(int id)
        {
            return await _repositorioDisciplinas.ExcluirAsync(id);
        }
    }
} 
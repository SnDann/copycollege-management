using college_management.Dados.Repositorios;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Servicos
{
    public class MatriculaServico
    {
        private readonly RepositorioBase<Matricula> _repositorioMatriculas;
        private readonly RepositorioBase<Turma> _repositorioTurmas;
        private readonly RepositorioBase<Aluno> _repositorioAlunos;

        public MatriculaServico(
            RepositorioBase<Matricula> repositorioMatriculas,
            RepositorioBase<Turma> repositorioTurmas,
            RepositorioBase<Aluno> repositorioAlunos)
        {
            _repositorioMatriculas = repositorioMatriculas;
            _repositorioTurmas = repositorioTurmas;
            _repositorioAlunos = repositorioAlunos;
        }

        // Métodos para Matrículas
        public async Task<IEnumerable<Matricula>> ListarMatriculasAsync()
        {
            return await _repositorioMatriculas.ListarAsync();
        }

        public async Task<IEnumerable<Matricula>> ListarMatriculasPorAlunoAsync(int alunoId)
        {
            return await _repositorioMatriculas.ListarAsync(m => m.AlunoId == alunoId);
        }

        public async Task<Matricula?> ObterMatriculaAsync(int id)
        {
            return await _repositorioMatriculas.ObterAsync(m => m.Id == id);
        }

        public async Task<bool> CriarMatriculaAsync(Matricula matricula)
        {
            return await _repositorioMatriculas.AdicionarAsync(matricula);
        }

        public async Task<bool> AtualizarMatriculaAsync(Matricula matricula)
        {
            return await _repositorioMatriculas.AtualizarAsync(matricula);
        }

        public async Task<bool> ExcluirMatriculaAsync(int id)
        {
            return await _repositorioMatriculas.ExcluirAsync(id);
        }

        // Métodos para Turmas
        public async Task<IEnumerable<Turma>> ListarTurmasAsync()
        {
            return await _repositorioTurmas.ListarAsync();
        }

        public async Task<IEnumerable<Turma>> ListarTurmasPorDisciplinaAsync(int disciplinaId)
        {
            return await _repositorioTurmas.ListarAsync(t => t.DisciplinaId == disciplinaId);
        }

        public async Task<Turma?> ObterTurmaAsync(int id)
        {
            return await _repositorioTurmas.ObterAsync(t => t.Id == id);
        }

        public async Task<bool> CriarTurmaAsync(Turma turma)
        {
            return await _repositorioTurmas.AdicionarAsync(turma);
        }

        public async Task<bool> AtualizarTurmaAsync(Turma turma)
        {
            return await _repositorioTurmas.AtualizarAsync(turma);
        }

        public async Task<bool> ExcluirTurmaAsync(int id)
        {
            return await _repositorioTurmas.ExcluirAsync(id);
        }

        // Métodos para Alunos
        public async Task<IEnumerable<Aluno>> ListarAlunosAsync()
        {
            return await _repositorioAlunos.ListarAsync();
        }

        public async Task<Aluno?> ObterAlunoAsync(int id)
        {
            return await _repositorioAlunos.ObterAsync(a => a.Id == id);
        }

        public async Task<bool> CriarAlunoAsync(Aluno aluno)
        {
            return await _repositorioAlunos.AdicionarAsync(aluno);
        }

        public async Task<bool> AtualizarAlunoAsync(Aluno aluno)
        {
            return await _repositorioAlunos.AtualizarAsync(aluno);
        }

        public async Task<bool> ExcluirAlunoAsync(int id)
        {
            return await _repositorioAlunos.ExcluirAsync(id);
        }
    }
} 
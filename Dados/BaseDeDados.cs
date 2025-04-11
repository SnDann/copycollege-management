using college_management.Models;

namespace college_management.Dados
{
	public class BaseDeDados
	{
		private readonly IRepositorio<Aluno> _alunos;
		private readonly IRepositorio<Curso> _cursos;
		private readonly IRepositorio<Disciplina> _disciplinas;
		private readonly IRepositorio<Matricula> _matriculas;
		private readonly IRepositorio<Professor> _professores;
		private readonly IRepositorio<Turma> _turmas;

		public BaseDeDados(
			IRepositorio<Aluno> alunos,
			IRepositorio<Curso> cursos,
			IRepositorio<Disciplina> disciplinas,
			IRepositorio<Matricula> matriculas,
			IRepositorio<Professor> professores,
			IRepositorio<Turma> turmas)
		{
			_alunos = alunos;
			_cursos = cursos;
			_disciplinas = disciplinas;
			_matriculas = matriculas;
			_professores = professores;
			_turmas = turmas;
		}

		// Métodos para acessar os repositórios
		public IRepositorio<Aluno> Alunos => _alunos;
		public IRepositorio<Curso> Cursos => _cursos;
		public IRepositorio<Disciplina> Disciplinas => _disciplinas;
		public IRepositorio<Matricula> Matriculas => _matriculas;
		public IRepositorio<Professor> Professores => _professores;
		public IRepositorio<Turma> Turmas => _turmas;
	}
}

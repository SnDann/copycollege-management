using college_management.Contextos;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Utilitarios
{
	public static class UtilitarioSeed
	{
		public static async Task IniciarBaseDeDados(CollegeDbContext context)
		{
			// Criar cursos
			var cursos = new List<Curso>
			{
				new Curso
				{
					Nome = "Ciência da Computação",
					Descricao = "Bacharelado em Ciência da Computação",
					CargaHoraria = 3200
				},
				new Curso
				{
					Nome = "Engenharia de Software",
					Descricao = "Bacharelado em Engenharia de Software",
					CargaHoraria = 3600
				}
			};

			await context.Cursos.AddRangeAsync(cursos);
			await context.SaveChangesAsync();

			// Criar professores
			var professores = new List<Professor>
			{
				new Professor
				{
					Nome = "João Silva",
					CPF = "12345678901",
					Email = "joao.silva@email.com",
					Telefone = "(11) 98765-4321",
					Titulacao = "Doutor"
				},
				new Professor
				{
					Nome = "Maria Santos",
					CPF = "98765432101",
					Email = "maria.santos@email.com",
					Telefone = "(11) 91234-5678",
					Titulacao = "Mestre"
				}
			};

			await context.Professores.AddRangeAsync(professores);
			await context.SaveChangesAsync();

			// Criar disciplinas
			var disciplinas = new List<Disciplina>
			{
				new Disciplina
				{
					Nome = "Programação I",
					Descricao = "Introdução à programação",
					CargaHoraria = 80,
					Curso = cursos[0]
				},
				new Disciplina
				{
					Nome = "Banco de Dados",
					Descricao = "Fundamentos de Banco de Dados",
					CargaHoraria = 80,
					Curso = cursos[0]
				},
				new Disciplina
				{
					Nome = "Engenharia de Requisitos",
					Descricao = "Fundamentos de Engenharia de Requisitos",
					CargaHoraria = 80,
					Curso = cursos[1]
				}
			};

			await context.Disciplinas.AddRangeAsync(disciplinas);
			await context.SaveChangesAsync();

			// Criar turmas
			var turmas = new List<Turma>
			{
				new Turma
				{
					Codigo = "PROG1-2024-1",
					Disciplina = disciplinas[0],
					Professor = professores[0],
					AnoLetivo = 2024,
					Semestre = 1,
					Vagas = 40,
					VagasDisponiveis = 40,
					Horario = "SEG 19:00-22:30"
				}
			};

			await context.Turmas.AddRangeAsync(turmas);
			await context.SaveChangesAsync();

			// Criar alunos
			var alunos = new List<Aluno>
			{
				new Aluno
				{
					Nome = "Pedro Oliveira",
					CPF = "11122233344",
					Email = "pedro.oliveira@email.com",
					Telefone = "(11) 97777-8888",
					Curso = cursos[0]
				},
				new Aluno
				{
					Nome = "Ana Costa",
					CPF = "44433322211",
					Email = "ana.costa@email.com",
					Telefone = "(11) 96666-7777",
					Curso = cursos[1]
				}
			};

			await context.Alunos.AddRangeAsync(alunos);
			await context.SaveChangesAsync();

			// Criar matrículas
			var matriculas = new List<Matricula>
			{
				new Matricula
				{
					Aluno = alunos[0],
					Turma = turmas[0],
					DataMatricula = DateTime.Now,
					Status = "MT"
				}
			};

			await context.Matriculas.AddRangeAsync(matriculas);
			await context.SaveChangesAsync();

			// Criar usuários
			var usuarios = new List<Usuario>
			{
				new Usuario
				{
					Login = "admin",
					Nome = "Administrador",
					Senha = "admin123",
					Tipo = TipoUsuario.Administrador
				},
				new Usuario
				{
					Login = "professor1",
					Nome = professores[0].Nome,
					Senha = "prof123",
					Tipo = TipoUsuario.Professor,
					Professor = professores[0]
				},
				new Usuario
				{
					Login = "aluno1",
					Nome = alunos[0].Nome,
					Senha = "aluno123",
					Tipo = TipoUsuario.Aluno,
					Aluno = alunos[0]
				}
			};

			await context.Usuarios.AddRangeAsync(usuarios);
			await context.SaveChangesAsync();
		}

		public static async Task<bool> ValidarDadosIniciais(CollegeDbContext context)
		{
			return await context.Cursos.AnyAsync() && await context.Usuarios.AnyAsync();
		}
	}
}

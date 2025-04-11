using Microsoft.EntityFrameworkCore;
using college_management.Models;

namespace college_management.Contextos
{
    public class CollegeDbContext : DbContext
    {
        public CollegeDbContext(DbContextOptions<CollegeDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração das entidades e relacionamentos
            modelBuilder.Entity<Aluno>()
                .HasMany(a => a.Matriculas)
                .WithOne(m => m.Aluno)
                .HasForeignKey(m => m.AlunoId);

            modelBuilder.Entity<Curso>()
                .HasMany(c => c.Disciplinas)
                .WithOne(d => d.Curso)
                .HasForeignKey(d => d.CursoId);

            modelBuilder.Entity<Disciplina>()
                .HasMany(d => d.Turmas)
                .WithOne(t => t.Disciplina)
                .HasForeignKey(t => t.DisciplinaId);

            modelBuilder.Entity<Professor>()
                .HasMany(p => p.Turmas)
                .WithOne(t => t.Professor)
                .HasForeignKey(t => t.ProfessorId);

            modelBuilder.Entity<Turma>()
                .HasMany(t => t.Matriculas)
                .WithOne(m => m.Turma)
                .HasForeignKey(m => m.TurmaId);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Aluno)
                .WithOne()
                .HasForeignKey<Usuario>(u => u.AlunoId);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Professor)
                .WithOne()
                .HasForeignKey<Usuario>(u => u.ProfessorId);
        }
    }
} 
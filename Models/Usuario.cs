using System.ComponentModel.DataAnnotations;

namespace college_management.Models
{
    public enum TipoUsuario
    {
        Administrador,
        Professor,
        Aluno
    }

    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public required string Login { get; set; }

        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string Senha { get; set; }

        public TipoUsuario Tipo { get; set; }

        public int? AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

        public int? ProfessorId { get; set; }
        public Professor? Professor { get; set; }
    }
} 
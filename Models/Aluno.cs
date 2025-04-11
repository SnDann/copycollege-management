using System.ComponentModel.DataAnnotations;

namespace college_management.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        
        [Required]
        public required string Nome { get; set; }
        
        [Required]
        public required string CPF { get; set; }
        
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        
        [Required]
        [Phone]
        public required string Telefone { get; set; }
        
        public int CursoId { get; set; }
        public required Curso Curso { get; set; }
        
        public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
    }
} 
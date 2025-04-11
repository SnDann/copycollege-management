using System.ComponentModel.DataAnnotations;

namespace college_management.Models
{
    public class Professor
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
        
        [Required]
        public required string Titulacao { get; set; }
        
        public ICollection<Turma> Turmas { get; set; } = new List<Turma>();
    }
} 
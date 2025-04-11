using System.ComponentModel.DataAnnotations;

namespace college_management.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        
        [Required]
        public required string Nome { get; set; }
        
        [Required]
        public required string Descricao { get; set; }
        
        public int CargaHoraria { get; set; }
        
        public int CursoId { get; set; }
        public required Curso Curso { get; set; }
        
        public ICollection<Turma> Turmas { get; set; } = new List<Turma>();
    }
} 
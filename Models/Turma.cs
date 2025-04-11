using System.ComponentModel.DataAnnotations;

namespace college_management.Models
{
    public class Turma
    {
        public int Id { get; set; }
        
        [Required]
        public required string Codigo { get; set; }
        
        public int DisciplinaId { get; set; }
        public required Disciplina Disciplina { get; set; }
        
        public int ProfessorId { get; set; }
        public required Professor Professor { get; set; }
        
        public int AnoLetivo { get; set; }
        public int Semestre { get; set; }
        public int Vagas { get; set; }
        public int VagasDisponiveis { get; set; }
        
        [Required]
        public required string Horario { get; set; }
        
        public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
    }
} 
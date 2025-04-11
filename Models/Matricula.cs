using System.ComponentModel.DataAnnotations;

namespace college_management.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        
        public int AlunoId { get; set; }
        public required Aluno Aluno { get; set; }
        
        public int TurmaId { get; set; }
        public required Turma Turma { get; set; }
        
        public DateTime DataMatricula { get; set; }
        
        public decimal? Nota { get; set; }
        public int? Faltas { get; set; }
        
        [Required]
        public required string Status { get; set; } // AP (Aprovado), RP (Reprovado), MT (Matriculado)
    }
} 
using System.ComponentModel.DataAnnotations;

namespace college_management.Models
{
    public class Curso
    {
        public int Id { get; set; }
        
        [Required]
        public required string Nome { get; set; }
        
        [Required]
        public required string Descricao { get; set; }
        
        [Required]
        public int DuracaoSemestres { get; set; }
        
        public int CargaHoraria { get; set; }
        
        public ICollection<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
        public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
} 
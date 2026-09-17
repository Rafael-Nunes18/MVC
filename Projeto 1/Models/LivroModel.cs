using System.ComponentModel.DataAnnotations;

namespace Projeto_1.Models
{
    public class LivroModel
    {
        public int LivroId { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty;
        public DateTime DataLivro { get; set; } = DateTime.Now;

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; } = string.Empty;

        [StringLength(300)]
        public string Imagem { get; set; } = string.Empty;

    }
}

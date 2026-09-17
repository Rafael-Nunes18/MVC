using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Projeto_1.Models
{

    [Index(nameof(Email), IsUnique = true)]
    public class UsuarioModel
    {
        public int UsuarioId { get; set; }


        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;


        [Required]
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Senha { get; set; } = string.Empty;
    }
}

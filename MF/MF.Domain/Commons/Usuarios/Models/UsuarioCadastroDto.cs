using System.ComponentModel.DataAnnotations;

namespace MF.Domain.Commons.Usuarios.Models
{
    public class UsuarioCadastroDto
    {
        [Required(ErrorMessage = "Nome é obrigatório"), MaxLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Login é obrigatório"), MaxLength(50)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Email é obrigatório"), MaxLength(200)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obirgatória"), MinLength(8), MaxLength(15)]
        public string Senha { get; set; }
    }
}
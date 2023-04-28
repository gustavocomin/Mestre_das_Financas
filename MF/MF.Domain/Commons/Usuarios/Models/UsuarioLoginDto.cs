using System.ComponentModel.DataAnnotations;

namespace MF.Domain.Commons.Usuarios.Models
{
    public class UsuarioLoginDto : Usuario
    {
        [Required(ErrorMessage = "Login é obrigatório"), MaxLength(50)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é obirgatória"), MaxLength(8)]
        public string Senha { get; set; }
    }
}
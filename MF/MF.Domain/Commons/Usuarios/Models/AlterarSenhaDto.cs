namespace MF.Domain.Commons.Usuarios.Models
{
    public class AlterarSenhaDto
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SenhaRepetida { get; set; }
    }
}
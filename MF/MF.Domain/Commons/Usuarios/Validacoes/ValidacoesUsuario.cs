using MF.Domain.Commons.Usuarios.Models;

namespace MF.Domain.Commons.Usuarios.Validacoes
{
    public class ValidacoesUsuario : IValidacoesUsuario
    {
        private readonly IRepUsuario _repUsuario;

        public ValidacoesUsuario(IRepUsuario repUsuario)
        {
            _repUsuario = repUsuario;
        }

        public void ValidaLoginUnico(UsuarioCadastroDto dto)
        {
            List<Usuario> usuarios = _repUsuario.FindAll<Usuario>().Where(x => x.Login.Trim().ToUpper() == dto.Login.Trim().ToUpper()).ToList();
            if (usuarios.Any())
                throw new Exception("O nome de usuário inserido já existe. Por favor, escolha um nome de usuário diferente.");
        }

        public void ValidaEmailUnico(UsuarioCadastroDto dto)
        {
            List<Usuario> usuarios = _repUsuario.FindAll<Usuario>().Where(x => x.Email.Trim().ToUpper() == dto.Email.Trim().ToUpper()).ToList();
            if (usuarios.Any())
                throw new Exception("O email informado já está sendo utilizado. Por favor, informe outro email.");
        }
    }
}
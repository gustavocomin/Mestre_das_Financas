using MF.Domain.Commons.Usuarios;

namespace MF.Domain.Configuration
{
    public interface IAuthenticationService
    {
        string GenerateToken(Usuario usuario);
    }
}
using MF.Domain.Commons.Usuarios.ViewModel;

namespace MF.Domain.Configuration
{
    public interface IAuthenticationService
    {
        string GenerateToken(UserViewModel userViewModel);
    }
}
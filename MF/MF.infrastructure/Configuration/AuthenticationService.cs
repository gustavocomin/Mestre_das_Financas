using MF.Domain.Commons.Usuarios.ViewModel;
using MF.Domain.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MF.infrastructure.Configuration
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _configuration;

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(UserViewModel userViewModel)
        {
            var secret = Encoding.ASCII.GetBytes(_configuration.GetSection("JwtConfigurations:Secret").Value);
            var symmetricSecurityKey = new SymmetricSecurityKey(secret);
            SecurityTokenDescriptor securityTokenDescriptor = new()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userViewModel.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, userViewModel.Login),
                    new Claim(ClaimTypes.NameIdentifier, userViewModel.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler jwtsecurityTokenHandler = new();
            var tokenGenerated = jwtsecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = "Bearer " + jwtsecurityTokenHandler.WriteToken(tokenGenerated);
            return token;
        }
    }
}
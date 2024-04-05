using ClinicaMedica.Core.Repositorios;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace ClinicaMedica.Infrastructure.Authentication
{
    public class AuthenticationService : IAuthService
    {
        private readonly IConfiguration _configuration;
        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string ComputeSha256Hash(string password)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {
                byte[] bytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // x2 faz com que seja convertido em representação hexadecimal
                }

                return builder.ToString();
            }
        }

        public string GenerateJwtToken(string email, string role)
        {
            throw new NotImplementedException();
        }
    }
}

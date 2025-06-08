namespace Mango.Services.AuthAPI.Models
{
    public class JwtOptions
    {
        public string Sceret { get; set; } = string.Empty;

        public string Issuer { get; set; } = string.Empty;

        public string Audienece { get; set; } = string.Empty;
    }           
}              

namespace Mango.Services.AuthAPI.Models.Dto
{
    public class LoginResponseDto
    {
        public UserDto Username { get; set; }
        public string Token { get; set; }
    }
}

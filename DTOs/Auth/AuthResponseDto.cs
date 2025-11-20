namespace ECommerce_Flutter3.DTOs.Auth
{
    public class AuthResponseDto
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? Token { get; set; }
        public UserInfoDto? User { get; set; }
    }
}

using ECommerce_Flutter3.Models;

namespace ECommerce_Flutter3.Services
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(ApplicationUser user);
    }
}
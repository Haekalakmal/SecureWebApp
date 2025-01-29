using Microsoft.AspNetCore.Identity;
namespace SecureWebApp.Models
{
    public class User : IdentityUser
    {
        public string Role { get; set; }
    }
}
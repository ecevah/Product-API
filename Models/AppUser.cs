using Microsoft.AspNetCore.Identity;

namespace ProductAPI2.Models
{
    public class AppUser: IdentityUser<int>
    {
        public string FullName { get; set; } = null!;
        public DateTime DateAdded { get; set; }
    }
}
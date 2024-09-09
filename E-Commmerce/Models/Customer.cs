using Microsoft.AspNetCore.Identity;

namespace E_Commmerce.Models
{
    public class Customer:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ImageName { get; set; }
        public string? ContentType { get; set; } 

    }
}

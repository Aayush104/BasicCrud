using Microsoft.AspNetCore.Identity;

namespace BasicCrud.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }    

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}

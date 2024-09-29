using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication2.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string Name {get; set;}

        public string ? ProfilePicture { get; set; }



    }
}

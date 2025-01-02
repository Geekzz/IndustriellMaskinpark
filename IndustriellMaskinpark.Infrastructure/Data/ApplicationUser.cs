using Microsoft.AspNetCore.Identity;

namespace IndustriellMaskinpark.Infrastructure.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;
    }

}

using Microsoft.AspNetCore.Identity;

namespace FoodHelper.Areas.Identity.Data
{
    public class MyUserRole : IdentityRole
    {
        public string Description { get; set; }
    }
}

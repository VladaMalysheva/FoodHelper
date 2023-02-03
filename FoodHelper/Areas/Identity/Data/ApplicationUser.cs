using Microsoft.AspNetCore.Identity;

namespace FoodHelper.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public List<Ingredient>? Ingredients { get; set; }
    }
}

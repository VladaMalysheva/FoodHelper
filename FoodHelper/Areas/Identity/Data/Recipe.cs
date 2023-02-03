namespace FoodHelper.Areas.Identity.Data
{
    public class Recipe
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Ingredient>? Ingredients { get; set; }
    }
}

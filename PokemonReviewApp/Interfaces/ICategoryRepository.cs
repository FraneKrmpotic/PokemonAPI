using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
<<<<<<< HEAD
        bool CategoryExists(int categoryId);
=======
        bool CategoryExists(int id);
>>>>>>> dbabb771d712ee8312727e5f58231582232f9871
    }
}

using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int categoryId);
<<<<<<< HEAD
        bool CreateCategory(Category category);
        bool Save();
=======
>>>>>>> 3abb30784c45f3d9e26131324993b6da1549d993
    }
}

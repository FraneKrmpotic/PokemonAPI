<<<<<<< HEAD
﻿using AutoMapper;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
=======
﻿using PokemonReviewApp.Interfaces;
>>>>>>> dbabb771d712ee8312727e5f58231582232f9871
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
<<<<<<< HEAD
        private DataContext _context;
        private readonly IMapper _mapper;

        public CategoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool CategoryExists(int categoryId)
        {
            return _context.Categories.Any(c => c.Id == categoryId);
=======
        public bool CategoryExists(int id)
        {
            throw new NotImplementedException();
>>>>>>> dbabb771d712ee8312727e5f58231582232f9871
        }

        public ICollection<Category> GetCategories()
        {
<<<<<<< HEAD
            return _context.Categories.ToList();
=======
            throw new NotImplementedException();
>>>>>>> dbabb771d712ee8312727e5f58231582232f9871
        }

        public Category GetCategory(int id)
        {
<<<<<<< HEAD
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
=======
            throw new NotImplementedException();
>>>>>>> dbabb771d712ee8312727e5f58231582232f9871
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
<<<<<<< HEAD
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
=======
            throw new NotImplementedException();
>>>>>>> dbabb771d712ee8312727e5f58231582232f9871
        }
    }
}

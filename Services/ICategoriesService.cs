using System.Collections.Generic;

namespace ProductsAPI.Services
{
    public interface ICategoriesService
    {
        public List<Category> GetCategories();

        public Category AddCategory(Category CategoryItem);

        public Category UpdateCategory(int id, Category CategoryItem);

        public int DeleteCategory(int id);
    }
}

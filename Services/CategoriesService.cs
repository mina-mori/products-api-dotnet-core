using System.Collections.Generic;

namespace ProductsAPI.Services
{
    public class CategoriesService: ICategoriesService
    {

        private List<Category> _categoryItems;

        public CategoriesService()
        {
            _categoryItems = new List<Category>();
        }

        public List<Category> GetCategories()
        {
            return _categoryItems;
        }

        public Category AddCategory(Category categoryItem)
        {
            _categoryItems.Add(categoryItem);
            return categoryItem;
        }

        public Category UpdateCategory(int id, Category categoryItem)
        {
            for (var index = _categoryItems.Count - 1; index >= 0; index--)
            {
                if (_categoryItems[index].ID == id)
                {
                    _categoryItems[index] = categoryItem;
                }
            }
            return categoryItem;
        }

        public int DeleteCategory(int id)
        {
            for (var index = _categoryItems.Count - 1; index >= 0; index--)
            {
                if (_categoryItems[index].ID == id)
                {
                    _categoryItems.RemoveAt(index);
                }
            }

            return id;
        }


    }
}

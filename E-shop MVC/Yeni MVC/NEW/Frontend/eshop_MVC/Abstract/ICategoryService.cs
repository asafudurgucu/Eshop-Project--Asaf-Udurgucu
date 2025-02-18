using eshop_MVC.Models;

namespace eshop_MVC.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync();
        Task<IEnumerable<CategoryModel>> GetActiveCategoriesAsync();
        Task<IEnumerable<CategoryModel>> GetPassiveCategoriesAsync();
        Task<CategoryModel> GetCategoriesAsync(int id);
        Task<int> GetCategoriyCountAsync(int id);
        Task<AddCategoryModel> AddCategoriyAsync(AddCategoryModel category);
        Task<bool> UpdateCategoryModel(UpdateCategoryModel category);
        Task DeleteCategoryModel(int id);
    }
}

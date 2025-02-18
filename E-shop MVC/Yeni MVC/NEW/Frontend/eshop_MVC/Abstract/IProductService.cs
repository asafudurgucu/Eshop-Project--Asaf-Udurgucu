using eshop_MVC.Models;


namespace eshop_MVC.Abstract
{
    public interface IProductService
    {

        Task<ProductModel> AddAsync(AddProductModel productModel); //
        Task<IEnumerable<ProductModel>> GetAllAsync(); //
        Task<IEnumerable<ProductModel>> GetAllActiveAsync(); //
        Task<IEnumerable<ProductModel>> GetAllPassiveAsync(); //
        Task<IEnumerable<ProductModel>> GetAllWithCategoriesAsync();
        Task<IEnumerable<ProductModel>> GetAllWithCategoriesFalseAsync();//
        Task<IEnumerable<ProductModel>> GetByCategoryAsync(int categoryId); // Kategoriye göre ürünleri alma metodu //
        Task<ProductModel> GetAsync(int id); //
        Task<ProductModel> GetWithCategoriesAsync(int id);  // 
        Task<GetUpdateProductModel> UpdateGetWithCategoriesAsync(int id);  // 
        Task<int> GetCountAsync(); //
        Task<int> GetCountAsync(bool isActive); //
        Task<int> GetCountByCategory(int categoryId); //
        Task<bool> UpdateAsync(UpdateProductModel productModel); //
        Task<bool> UpdateIsActiveAsync(int id); //
        Task<bool> DeleteAsync(int id); //

    }
}

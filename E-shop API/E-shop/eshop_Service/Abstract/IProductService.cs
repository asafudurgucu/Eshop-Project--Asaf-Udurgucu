using System;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;

namespace eshop_Service.Abstract;

public interface IProductService
{

                Task<ResponseDTO<ProductDTO>> GetAsync(int id);
                Task<ResponseDTO<ProductDTO>> GetWithCategoriesAsync(int id);
                Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync();
                Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync(bool? isActive);
                Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllWithCategoriesAsync();
                Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllWithCategoriesFalseAsync();
                Task<ResponseDTO<IEnumerable<ProductDTO>>> GetByCategoryAsync(int categoryId);
                Task<ResponseDTO<ProductDTO>> AddAsync(ProductCreateDTO productCreateDTO);
                Task<ResponseDTO<NoContent>> UpdateAsync(ProductUpdateDTO productUpdateDTO);
                Task<ResponseDTO<NoContent>> DeleteAsync(int id);
                Task<ResponseDTO<int>> GetCountAsync();
                Task<ResponseDTO<int>> GetCountAsync(bool? isActive);
                Task<ResponseDTO<int>> GetCountByCategory(int categoryId);
                Task<ResponseDTO<bool>> UpdateIsActiveAsync(int id);

}

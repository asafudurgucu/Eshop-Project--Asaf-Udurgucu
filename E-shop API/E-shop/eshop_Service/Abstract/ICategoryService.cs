using System;
using Azure;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;

namespace eshop_Service.Abstract;

public interface ICategoryService
{

    Task<ResponseDTO<CategoryDTO>> GetAsync(int id);
    Task<ResponseDTO<IEnumerable<CategoryDTO>>> GetAllAsync();//Ok
    Task<ResponseDTO<IEnumerable<CategoryDTO>>> GetAllAsync(bool? isActive);//Ok
    Task<ResponseDTO<CategoryDTO>> AddAsync(CategoryCreateDTO categoryCreateDTO);//Ok
    Task<ResponseDTO<NoContent>> UpdateAsync(CategoryUpdateDTO categoryUpdateDTO);//Ok
    Task<ResponseDTO<NoContent>> DeleteAsync(int categoryId);//Ok
    Task<ResponseDTO<int>> CountAsync();//Ok
    Task<ResponseDTO<int>> CountAsync(bool? isActive);//Ok
    Task<ResponseDTO<bool>> UpdateIsActiveAsync(int id);

}

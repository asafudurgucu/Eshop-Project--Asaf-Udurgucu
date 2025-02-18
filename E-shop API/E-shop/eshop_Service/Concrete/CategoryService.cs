using System;
using AutoMapper;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;

namespace eshop_Service.Concrete;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<Category> _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> categoryRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDTO<CategoryDTO>> AddAsync(CategoryCreateDTO categoryCreateDTO)
{
    Category category = _mapper.Map<Category>(categoryCreateDTO);
    await _unitOfWork.GetRepository<Category>().AddAsync(category);
    var result = await _unitOfWork.SaveAsync();
    if(result<=0)//Eğer kayıt gerçekleşmemişse
    {
        return ResponseDTO<CategoryDTO>.Fail("Bir hata oluştu!", 500);
    }
    CategoryDTO categoryDTO = _mapper.Map<CategoryDTO>(category);
    return ResponseDTO<CategoryDTO>.Success(categoryDTO, 201);
}

public async Task<ResponseDTO<int>> CountAsync()
{
    var count = await _unitOfWork.GetRepository<Category>().CountAsync();
    return ResponseDTO<int>.Success(count, 200);
}

public async Task<ResponseDTO<int>> CountAsync(bool? isActive)
{
    var count = await _unitOfWork.GetRepository<Category>().CountAsync(x=>x.isActive==isActive);
    return ResponseDTO<int>.Success(count, 200);
}

public async Task<ResponseDTO<NoContent>> DeleteAsync(int categoryId)
{
    var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(categoryId);
    if(category == null)
    {
        return ResponseDTO<NoContent>.Fail("Kategori bulunamadığı için işlem yapılamadı", 404);
    }
    _unitOfWork.GetRepository<Category>().Delete(category);
    await _unitOfWork.SaveAsync();
    return ResponseDTO<NoContent>.Success(200);
}

public async Task<ResponseDTO<IEnumerable<CategoryDTO>>> GetAllAsync()
{
    var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync();
    if(categories == null)
    {
        return ResponseDTO<IEnumerable<CategoryDTO>>.Fail("Sunucuda bir sorun oluştu, daha sonra tekrar deneyiniz", 500);
    }
    if (categories.Count() == 0)
    {
        return ResponseDTO<IEnumerable<CategoryDTO>>.Fail("Hiç kategori bulunamadı!", 404);
    }
    var categoryDTOs = _mapper.Map<IEnumerable<CategoryDTO>>(categories);
    return ResponseDTO<IEnumerable<CategoryDTO>>.Success(categoryDTOs, 200);
}
public async Task<ResponseDTO<IEnumerable<CategoryDTO>>> GetAllAsync(bool? isActive)
{
    var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync(x=>x.isActive==isActive);
    if (categories == null)
    {
        return ResponseDTO<IEnumerable<CategoryDTO>>.Fail("Sunucuda bir sorun oluştu, daha sonra tekrar deneyiniz", 500);
    }
    if (categories.Count() == 0)
    {
        return ResponseDTO<IEnumerable<CategoryDTO>>.Fail("Hiç kategori bulunamadı!", 404);
    }
    var categoryDTOs = _mapper.Map<IEnumerable<CategoryDTO>>(categories);
    return ResponseDTO<IEnumerable<CategoryDTO>>.Success(categoryDTOs, 200);
}

public async Task<ResponseDTO<CategoryDTO>> GetAsync(int id)
{
    var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
    if(category == null)
    {
        return ResponseDTO<CategoryDTO>.Fail("İlgili kategori bulunamadı", 404);
    }
    var categoryDTO=_mapper.Map<CategoryDTO>(category);
    return ResponseDTO<CategoryDTO>.Success(categoryDTO, 200);
}

public async Task<ResponseDTO<NoContent>> UpdateAsync(CategoryUpdateDTO categoryUpdateDTO)
{
    var existsCategory = await _unitOfWork.GetRepository<Category>().GetByIdAsync(categoryUpdateDTO.Id);
    if(existsCategory == null)
    {
        return ResponseDTO<NoContent>.Fail("Kategori bulunamadığı için işlem yapılamadı", 404);
    }
    _mapper.Map(categoryUpdateDTO, existsCategory);
    existsCategory.ModifiedDate = DateTime.UtcNow;
    _unitOfWork.GetRepository<Category>().Update(existsCategory);
    await _unitOfWork.SaveAsync();
    return ResponseDTO<NoContent>.Success(204);
}

public async Task<ResponseDTO<bool>> UpdateIsActiveAsync(int id)
{
    var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
    if(category == null)
    {
        return ResponseDTO<bool>.Fail("Kategori bulunamadığı için işlem yapılamadı", 404);
    }
    category.isActive = !category.isActive;
    _unitOfWork.GetRepository<Category>().Update(category);
    await _unitOfWork.SaveAsync();
    return ResponseDTO<bool>.Success(category.isActive, 200);
}
}

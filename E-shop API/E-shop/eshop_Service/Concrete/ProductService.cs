using AutoMapper;
using eshop_Data.Abstract;
using eshop_Entity.Contcrete;
using eshop_Service.Abstract;
using eshop_Shared.DTOs;
using eshop_Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace eshop_Service.Concrete;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IGenericRepository<Product> _productRepository;
    private readonly IGenericRepository<Category> _categoryRepository;
    private readonly IImageService _imageService;

    public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Product> productRepository, IGenericRepository<Category> categoryRepository, IImageService imageService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _imageService = imageService;
    }

    public async Task<ResponseDTO<ProductDTO>> AddAsync(ProductCreateDTO productCreateDTO)
    {
        var product = _mapper.Map<Product>(productCreateDTO);
        if(productCreateDTO.Image != null)
        {
            var imageUrl = await _imageService.UploadImageAsync(productCreateDTO.Image);
                product.ImageUrl = imageUrl;
        }

        await _productRepository.AddAsync(product);
        var result = await _unitOfWork.SaveAsync();
        if (result <= 0)
        {
            return ResponseDTO<ProductDTO>.Fail("Bir sorun oluştu", 500);
        }

        product.ProductCategories =
            productCreateDTO.CategoryIds.Select(cId => new ProductCategories
            {
                ProductId = product.Id,
                CategoryId = cId
            }).ToList();
        _productRepository.Update(product);
        result = await _unitOfWork.SaveAsync();
        if (result <= 0)
        {
            return ResponseDTO<ProductDTO>.Fail("Bir sorun oluştu", 500);
        }
        ProductDTO productDTO = (await GetWithCategoriesAsync(product.Id)).Data;
        return ResponseDTO<ProductDTO>.Success(productDTO, 201);
    }

    public async Task<ResponseDTO<NoContent>> DeleteAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return ResponseDTO<NoContent>.Fail("Ürün bulunamadığı için işlem tamamlanamadı!", 404);
        }
        _productRepository.Delete(product);
        var result = await _unitOfWork.SaveAsync();
        if (result <= 0)
        {
            return ResponseDTO<NoContent>.Fail("Bir sorun oluştu", 500);
        }
        return ResponseDTO<NoContent>.Success(200);
    }

    public async Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync()
    {
        var products = await _productRepository.GetAllAsync();
        if (products == null)
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Bir sorun oluştu!", 500);
        }
        //if (products?.Count() == 0)
        if (!products.Any())
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Hiç ürün bulunamadı!", 404);
        }
        var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(products);
        return ResponseDTO<IEnumerable<ProductDTO>>.Success(productDTOs, 200);
    }

    public async Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllAsync(bool? isActive)
    {
        var products = await _productRepository.GetAllAsync(x => x.isActive == isActive);
        if (products == null)
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Bir sorun oluştu!", 500);
        }
        //if (products?.Count() == 0)
        if (!products.Any())
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Hiç ürün bulunamadı!", 404);
        }
        var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(products);
        return ResponseDTO<IEnumerable<ProductDTO>>.Success(productDTOs, 200);
    }

    public async Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllWithCategoriesAsync()
    {
        var products = await _productRepository.GetAllAsync(
                 x => x.isActive == true,
                 null, null,
                 query => query.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category)
                 );
        if (products == null)
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Bir sorun oluştu!", StatusCodes.Status500InternalServerError);
        }
        //if (products?.Count() == 0)
        if (!products.Any())
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Hiç ürün bulunamadı!", StatusCodes.Status404NotFound);
        }
        var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(products);
        return ResponseDTO<IEnumerable<ProductDTO>>.Success(productDTOs, StatusCodes.Status200OK);
    }

    public async Task<ResponseDTO<IEnumerable<ProductDTO>>> GetAllWithCategoriesFalseAsync()
    {
        var products = await _productRepository.GetAllAsync(
                 x => x.isActive == false,
                 null, null,
                 query => query.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category)
                 );
        if (products == null)
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Bir sorun oluştu!", StatusCodes.Status500InternalServerError);
        }
        //if (products?.Count() == 0)
        if (!products.Any())
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Hiç ürün bulunamadı!", StatusCodes.Status404NotFound);
        }
        var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(products);
        return ResponseDTO<IEnumerable<ProductDTO>>.Success(productDTOs, StatusCodes.Status200OK);
    }


    public async Task<ResponseDTO<ProductDTO>> GetAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return ResponseDTO<ProductDTO>.Fail("İlgili ürün bulunamadı!", 404);
        }
        var productDTO = _mapper.Map<ProductDTO>(product);
        return ResponseDTO<ProductDTO>.Success(productDTO, 200);
    }

    public async Task<ResponseDTO<IEnumerable<ProductDTO>>> GetByCategoryAsync(int categoryId)
    {
        var products = await _productRepository.GetAllAsync(
            x => x.isActive == true && x.ProductCategories.Any(pc => pc.CategoryId == categoryId),
            null
            );
        if (products == null)
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Bir sorun oluştu!", 500);
        }
        //if (products?.Count() == 0)
        if (!products.Any())
        {
            return ResponseDTO<IEnumerable<ProductDTO>>.Fail("Hiç ürün bulunamadı!", 404);
        }
        var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(products);
        return ResponseDTO<IEnumerable<ProductDTO>>.Success(productDTOs, 200);
    }

    public async Task<ResponseDTO<int>> GetCountAsync()
    {
        var count = await _productRepository.CountAsync();
        return ResponseDTO<int>.Success(count, 200);
    }

    public async Task<ResponseDTO<int>> GetCountAsync(bool? isActive)
    {
        var count = await _productRepository.CountAsync(x => x.isActive == isActive);
        return ResponseDTO<int>.Success(count, 200);
    }

    public async Task<ResponseDTO<int>> GetCountByCategory(int categoryId)
    {
        var categoryIsExists = await _categoryRepository.ExistsAsync(x => x.Id == categoryId);
        if (!categoryIsExists)
        {
            return ResponseDTO<int>.Fail("Böyle bir kategori bulunamadı!", 404);
        }
        var count = await _productRepository.CountAsync(
            x => x.isActive == true && x.ProductCategories.Any(pc => pc.CategoryId == categoryId)
        );
        return ResponseDTO<int>.Success(count, 200);
    }

    public async Task<ResponseDTO<ProductDTO>> GetWithCategoriesAsync(int id)
    {
        var product = await _productRepository.GetAsync(
            x => x.Id == id,
            query => query.Include(p => p.ProductCategories).ThenInclude(pc => pc.Category));
        if (product == null)
        {
            return ResponseDTO<ProductDTO>.Fail("İlgili ürün bulunamadı!", 404);
        }
        var productDTO = _mapper.Map<ProductDTO>(product);
        return ResponseDTO<ProductDTO>.Success(productDTO, 200);
    }

    public async Task<ResponseDTO<NoContent>> UpdateAsync(ProductUpdateDTO productUpdateDTO)
    {
        var product = await _productRepository.GetAsync(p => p.Id == productUpdateDTO.Id, query => query.Include(x => x.ProductCategories));
        if (product == null)
        {
            return ResponseDTO<NoContent>.Fail("İlgili ürün bulunamadığı için, güncelleme yapılamadı!", 404);
        }
        if (!product.isActive)
        {
            return ResponseDTO<NoContent>.Fail("İlgili ürün aktif olmadığı için, güncelleme yapılamadı!", 400);
        }
        if (productUpdateDTO.Image != null)
        {
            var imageUrl = await _imageService.UploadImageAsync(productUpdateDTO.Image);
            product.ImageUrl = imageUrl;
        }
        product.ProductCategories.Clear();
        _productRepository.Update(_mapper.Map<Product>(product));
        await _unitOfWork.SaveAsync();
        _mapper.Map(productUpdateDTO, product);

        product.ProductCategories =
            productUpdateDTO
            .CategoryIds.Select(cId => new ProductCategories
            {
                ProductId = product.Id,
                CategoryId = cId
            }).ToList();
        _productRepository.Update(product);
        await _unitOfWork.SaveAsync();
        return ResponseDTO<NoContent>.Success(204);
    }

    public async Task<ResponseDTO<bool>> UpdateIsActiveAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return ResponseDTO<bool>.Fail("İlgili ürün bulunamadığı için, işlem yapılamadı!", 404);
        }
        product.isActive = !product.isActive;
        _productRepository.Update(product);
        await _unitOfWork.SaveAsync();
        return ResponseDTO<bool>.Success(product.isActive, 200);
    }

}


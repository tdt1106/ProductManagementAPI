using ProductManagementAPI.Data;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Product> GetProductByIdAsync(int productId)
    {
        return await _unitOfWork.ProductRepository.GetByIdAsync(productId);
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _unitOfWork.ProductRepository.GetAllAsync();
    }

    public async Task AddProductAsync(Product product)
    {
        await _unitOfWork.ProductRepository.AddAsync(product);
        await _unitOfWork.CommitAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        await _unitOfWork.ProductRepository.UpdateAsync(product);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteProductAsync(int productId)
    {
        await _unitOfWork.ProductRepository.DeleteAsync(productId);
        await _unitOfWork.CommitAsync();
    }
}


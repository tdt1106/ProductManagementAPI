namespace ProductManagementAPI.Services;

using ProductManagementAPI.Data;
using ProductManagementAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Category> GetCategoryByIdAsync(int categoryId)
    {
        return await _unitOfWork.CategoryRepository.GetByIdAsync(categoryId);
    }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        return await _unitOfWork.CategoryRepository.GetAllAsync();
    }

    public async Task AddCategoryAsync(Category category)
    {
        await _unitOfWork.CategoryRepository.AddAsync(category);
        await _unitOfWork.CommitAsync();
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        await _unitOfWork.CategoryRepository.UpdateAsync(category);
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteCategoryAsync(int categoryId)
    {
        await _unitOfWork.CategoryRepository.DeleteAsync(categoryId);
        await _unitOfWork.CommitAsync();
    }
}


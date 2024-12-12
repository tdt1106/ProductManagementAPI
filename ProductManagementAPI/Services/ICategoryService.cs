namespace ProductManagementAPI.Services;

using ProductManagementAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetAllCategoriesAsync();
    Task<Category> GetCategoryByIdAsync(int id);
    Task AddCategoryAsync(Category category);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategoryAsync(int id);
}

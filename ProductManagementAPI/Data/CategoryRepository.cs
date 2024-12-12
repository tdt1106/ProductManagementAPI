namespace ProductManagementAPI.Data;
using Dapper;
using ProductManagementAPI.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

public class CategoryRepository : ICategoryRepository
{
    private readonly IDbConnection _connection;
    private readonly IDbTransaction _transaction;

    public CategoryRepository(IDbConnection connection, IDbTransaction transaction)
    {
        _connection = connection;
        _transaction = transaction;
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        return await _connection.QueryAsync<Category>("SELECT * FROM Categories", transaction: _transaction);
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        return await _connection.QueryFirstOrDefaultAsync<Category>(
            "SELECT * FROM Categories WHERE Id = @Id", new { Id = id }, transaction: _transaction);
    }

    public async Task AddAsync(Category category)
    {
        await _connection.ExecuteAsync(
            "INSERT INTO Categories (Name) VALUES (@Name)", category, transaction: _transaction);
    }

    public async Task UpdateAsync(Category category)
    {
        await _connection.ExecuteAsync(
            "UPDATE Categories SET Name = @Name WHERE Id = @Id", category, transaction: _transaction);
    }

    public async Task DeleteAsync(int id)
    {   
        await _connection.ExecuteAsync(
            "DELETE FROM Categories WHERE Id = @Id", new { Id = id }, transaction: _transaction);
    }
}


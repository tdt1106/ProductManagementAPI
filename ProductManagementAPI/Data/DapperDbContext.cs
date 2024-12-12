using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

public class DapperDbContext : IDisposable
{
    private readonly string _connectionString;
    private readonly string _databaseName;
    private IDbConnection _connection;
    public DapperDbContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
        var builder = new SqlConnectionStringBuilder(_connectionString);
        _databaseName = builder.InitialCatalog;
        builder.InitialCatalog = "master";
        MasterConnectionString = builder.ConnectionString;
    }

    private string MasterConnectionString { get; }

    public IDbConnection CreateConnection()
    {
        if (_connection == null || _connection.State == ConnectionState.Closed)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }
        return _connection;
    }

    public void EnsureDatabaseExists()
    {
        using var connection = new SqlConnection(MasterConnectionString);
        connection.Open();

        var checkDbQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{_databaseName}'";
        var dbExists = connection.ExecuteScalar<int?>(checkDbQuery) != null;

        if (!dbExists)
        {
            var createDbQuery = $"CREATE DATABASE [{_databaseName}]";
            connection.Execute(createDbQuery);
        }
    }

    public void Dispose()
    {
        if (_connection != null)
        {
            _connection.Dispose();
            _connection = null;
        }
    }
}

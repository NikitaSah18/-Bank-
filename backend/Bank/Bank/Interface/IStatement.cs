
using Bank.Models;
namespace Bank.Interface

{
    public interface IStatement
    {
        Task CreateAsync(Statement statement);
        Task<List<Statement>> GetAllAsync();
        Task UpdateAsync(Statement statement);
        Task DeleteAsync(Statement statement);
    }
}

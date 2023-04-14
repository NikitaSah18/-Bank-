using Bank.Data;
using Bank.Interface;
using Bank.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank.Repositories
{
    public class StatementRepositories : IStatement
    {
        private readonly ApplicationDbContext _context;

        public StatementRepositories (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Statement statement)
        {
            _context.Add(statement);
            await _context.SaveChangesAsync();
            
        }

        public async Task DeleteAsync(Statement statement)
        {
            _context.Statements.Remove(statement);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Statement>> GetAllAsync()
        {
            var statements = await _context.Statements.ToListAsync();
            return statements;
        }

        public async Task UpdateAsync(Statement statement)
        {
            _context.Statements.Update(statement);
            await _context.SaveChangesAsync();

        }
    }
}

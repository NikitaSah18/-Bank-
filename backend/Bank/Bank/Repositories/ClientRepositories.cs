using Bank.Data;
using Bank.Interface;
using Bank.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank.Repositories
{
    public class ClientRepositories : IClient
    {
        private readonly ApplicationDbContext _context;
        public ClientRepositories(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Client client)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Client client)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Client>> GetAllAsync()
        {
            var clients = await _context.Clients.ToListAsync();
            return clients;
        }

        public async Task<Client> GetByIdasync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task UpdateAsync(Client client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }
    }
}

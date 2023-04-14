using Bank.Models;

namespace Bank.Interface
{
    public interface IClient
    {
        Task CreateAsync(Client client);
        Task<List<Client>> GetAllAsync();
        Task <Client> GetByIdasync(int id);

        Task UpdateAsync(Client client);
        Task DeleteAsync(Client client);

    }
}

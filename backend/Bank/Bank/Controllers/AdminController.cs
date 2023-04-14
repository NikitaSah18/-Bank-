using Bank.Interface;
using Bank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IClient _clientRepositories;
        public AdminController(IClient client)
        {
            _clientRepositories = client;
        }
        [HttpGet("clients")]
        public async Task<List<Client>> ListClients()

        {
            return await _clientRepositories.GetAllAsync();

        }
        [HttpPost("client/create")]
        public async Task<Client> CreateClient(Client client)
        { 
            await _clientRepositories.CreateAsync(client);

            var (user, password) = GetUser();

            return client;
        }

        private (string? user, string? password) GetUser()
        {
            const string basic = "Basic ";

            var authToken = this.Request.Headers["Authorization"].FirstOrDefault()?.ToString();
            if (string.IsNullOrWhiteSpace(authToken) || !authToken.StartsWith(basic))
                return (null, null);

            var authInfoBase64 = Convert.FromBase64String(authToken.Substring(basic.Length));
            var authInfo = Encoding.UTF8.GetString(authInfoBase64).Split(':');
            return (authInfo[0], authInfo[1]);
        }
    }
}

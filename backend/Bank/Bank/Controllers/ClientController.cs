using Bank.Interface;
using Bank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Duende.IdentityServer.Models.IdentityResources;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClient _clientRepositories;
        public ClientController (IClient client)
        {
            _clientRepositories = client;
        }
        [HttpGet]
        public async Task<List<Client>> Get()

        {
            return await _clientRepositories.GetAllAsync();

        }

        [HttpGet("{id}")]

        public async Task<Client> GetClient(int id)
        {
            return await _clientRepositories.GetByIdasync(id);
        }
        
       /* public async Task Post()
        {
            var client = new Client()
            {
                
                FIO = "Sakharov",
                Phone = "79913450965",
                Adress = "International, d.14"
            };
            await _clientRepositories.CreateAsync(client);


        }*/
        
            
    }


}


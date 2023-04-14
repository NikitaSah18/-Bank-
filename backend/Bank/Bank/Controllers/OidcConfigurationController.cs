using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    public class OidcConfigurationController : Controller
    {
        private readonly ILogger<OidcConfigurationController> _logger;

        public OidcConfigurationController(
            IClientRequestParametersProvider clientRequestParametersProvider,
            ILogger<OidcConfigurationController> logger)
        {
            ClientRequestParametersProvider = clientRequestParametersProvider;
            _logger = logger;
        }

        public IClientRequestParametersProvider ClientRequestParametersProvider { get; }

        [HttpGet("_configuration/{ClientId}")]
        public IActionResult GetClientRequestParameters([FromRoute] string ClientId)
        {
            var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, ClientId);
            return Ok(parameters);
        }
    }
}
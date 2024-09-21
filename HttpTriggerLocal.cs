using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.MinhaFunction
{
    public class HttpTriggerLocal
    {
        private readonly ILogger<HttpTriggerLocal> _logger;

        public HttpTriggerLocal(ILogger<HttpTriggerLocal> logger)
        {
            _logger = logger;
        }

        [Function("HttpTriggerLocal")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}

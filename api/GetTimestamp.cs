using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Api;

public class GetTimestamp
{
    private readonly ILogger<GetTimestamp> _logger;

    public GetTimestamp(ILogger<GetTimestamp> logger)
    {
        _logger = logger;
    }

    [Function("timestamp")]
    public IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "timestamp")] HttpRequest req)
    {
        _logger.LogInformation("Returning current timestamp.");

        var now = DateTimeOffset.UtcNow;
        return new OkObjectResult(new
        {
            timestamp = now.ToString("o"),
            unixSeconds = now.ToUnixTimeSeconds()
        });
    }
}

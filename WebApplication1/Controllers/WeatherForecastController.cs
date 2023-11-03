using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/")]
public class TextController : ControllerBase
{
    private readonly ILogger<TextController> _logger;

    public TextController(ILogger<TextController> logger)
    {
        _logger = logger;
    }

    [HttpGet("text")]
    public IEnumerable<string> Get()
    {
        return new[] {
            "Docker", "Dotnet EF Core", "CI / CD pipline" 
        };
    }
}
//Password@168, sengkhimk-001
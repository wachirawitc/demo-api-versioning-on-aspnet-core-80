using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers.V1;

[ApiController]
[ApiVersion(1.0)]
[Route("v{version:apiVersion}/[controller]")]
public class ExampleController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello from V1";
    }
}
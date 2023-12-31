using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers.V2;

[ApiController]
[ApiVersion(2.0)]
[Route("v{version:apiVersion}/[controller]")]
public class ExampleController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello from V2";
    }
}
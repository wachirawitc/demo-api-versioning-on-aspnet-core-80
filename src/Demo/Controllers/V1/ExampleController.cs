using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers.V1;

[ApiController]
[ApiVersion(1.0)]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    public string Get()
    {
        return "Hello from V1";
    }
}
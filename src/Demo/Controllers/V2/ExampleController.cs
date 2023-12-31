using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers.V2;

[ApiController]
[ApiVersion(2.0)]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    public string Get()
    {
        return "Hello from V2";
    }
}
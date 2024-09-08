using Lazy.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lazy.Controllers;

[ApiController()]
[Route("api/first")]
public class FirstController : ControllerBase
{
    private readonly IFirstService _firstService;

    public FirstController(IFirstService firstService)
    {
        _firstService = firstService;
    }

    [HttpGet("do-something")]
    public string DoSomething()
    {
        return _firstService.DoSomething();
    }
    
    [HttpGet("do-something-and-call-dependent-service")]
    public string DoSomethingAndCallDependentService()
    {
        return _firstService.DoSomethingAndCallDependentService();
    }
    
}
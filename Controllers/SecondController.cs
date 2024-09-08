using Lazy.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lazy.Controllers;

[ApiController]
[Route("api/second")]
public class SecondController : ControllerBase
{
    private readonly ISecondService _secondService;

    public SecondController(ISecondService secondService)
    {
        _secondService = secondService;
    }

    [HttpGet("do-something")]
    public string DoSomething()
    {
        return _secondService.DoSomething();
    }

    [HttpGet("do-something-and-call-dependent-service")]
    public string DoSomethingAndCallDependentService()
    {
        return _secondService.DoSomethingAndCallDependentService();
    }

    [HttpGet("do-something-and-call-dependent-service-instance-check")]
    public string DoSomethingAndCallDependentServiceCheck()
    {
        return
            $"First call: {_secondService.DoSomethingAndCallDependentService()} \nSecond call: {_secondService.DoSomethingAndCallDependentService()}";
    }
}
namespace Lazy.Services;

public class FirstService : IFirstService
{
    private readonly ISecondService _secondService;

    public FirstService(ISecondService secondService)
    {
        _secondService = secondService;
    }
    
    public string DoSomething()
    {
        return "FirstService performed an action";
    }

    public string DoSomethingAndCallDependentService()
    {
        return $"{DoSomething()} and directly called its dependent service: {_secondService.DoSomething()}";
    }

}
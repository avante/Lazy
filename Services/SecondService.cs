namespace Lazy.Services;

public class SecondService : ISecondService
{
    private readonly Lazy<IFirstService> _firstService;

    public SecondService(Lazy<IFirstService> firstService)
    {
        _firstService = firstService;
    }
    
    public string DoSomething()
    {
        return "SecondService performed an action";
    }
     
    public string DoSomethingAndCallDependentService()
    {
        return $"{DoSomething()} and lazily called its dependent service: {_firstService.Value.DoSomething()}";
    }
}
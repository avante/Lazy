namespace Lazy.Services;

public class FirstService : IFirstService
{
    private readonly ISecondService _secondService;
    private readonly int _id;
    private static int _justASimpleInstanceCounter = 0;

    public FirstService(ISecondService secondService)
    {
        _secondService = secondService;
        _id = ++_justASimpleInstanceCounter;
    }
    
    public string DoSomething()
    {
        return $"FirstService (Instance {_id}) performed an action";
    }

    public string DoSomethingAndCallDependentService()
    {
        return $"{DoSomething()} and directly called its dependent service: {_secondService.DoSomething()}";
    }

}